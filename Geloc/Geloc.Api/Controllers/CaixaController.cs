using Geloc.Dados;
using Geloc.Dominio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Geloc.Api.QueryParams;

namespace Geloc.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/caixa")]
    public class CaixaController : Controller
    {
        private readonly Contexto _context;

        public CaixaController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Caixa
        [HttpGet]
        public IEnumerable<Caixa> GetCaixa([FromQuery] CaixaQueryParams query)
        {
            return _context.Caixa.Where(c => c.DataCaixa >= query.DataInicial && c.DataCaixa <= query.DataFinal).OrderByDescending(c => c.CaixaId).ToList();
        }

        [HttpGet("saldo")]
        public Decimal GetSaldo(string data)
        {
            Decimal saldo = 0;
            
            saldo = SaldoAtual(DateTime.Now);

            return saldo;
        }

        // GET: api/Caixa/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCaixa([FromRoute] int id)
        {
            var caixa = await _context.Caixa.FindAsync(id);

            if (caixa == null)
            {
                return NotFound();
            }

            return Ok(caixa);
        }
        

        // PUT: api/Caixa/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCaixa([FromRoute] int id, [FromBody] Caixa caixa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != caixa.CaixaId)
            {
                return BadRequest();
            }

            _context.Entry(caixa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CaixaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Caixa
        [HttpPost]
        public async Task<IActionResult> PostCaixa([FromBody] Caixa caixa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (estaFechado(caixa.DataCaixa))
            {
                return Content("O caixa do dia está fechado!");
            }

            if (caixa.TipoCaixaId == 1 && estaAberto(caixa.DataCaixa))
            {
                return Content("O Caixa já foi aberto!");
            }

            if (caixa.TipoCaixaId > 1 && !estaAberto(caixa.DataCaixa))
            {
                return Content("O caixa não foi aberto");
            }

            if (caixa.TipoCaixaId < 4 && caixa.ValorEntrada == 0)
            {
                return Content("Não foi informado o valor da Entrada");
            }

            if ((caixa.TipoCaixaId > 3 && caixa.TipoCaixaId < 6) && caixa.ValorSaida == 0)
            {
                return Content("Não foi informado o valor da Saída");
            }

            if ((caixa.TipoCaixaId < 4) || ((caixa.TipoCaixaId > 3 && caixa.TipoCaixaId < 6) && temSaldoParaSaida(caixa.DataCaixa,caixa.ValorSaida)))
            {

               Decimal saldoAnterior = SaldoAnterior(caixa.DataCaixa);
               caixa.ValorAnterior = saldoAnterior;
               caixa.ValorAtual = (saldoAnterior + caixa.ValorEntrada) - caixa.ValorSaida;
               
               if (caixa.TipoCaixaId < 4 && caixa.ValorSaida > 0)
               {
                   caixa.ValorSaida = 0;
               }

               if ((caixa.TipoCaixaId > 3 && caixa.TipoCaixaId < 6) && caixa.ValorEntrada > 0)
               {
                   caixa.ValorEntrada = 0;
               }

               if (caixa.TipoCaixaId == 1)
               {
                   caixa.Descricao = "Abertura do caixa no dia " + caixa.DataCaixa.ToShortDateString() + " com o Valor de Entrada: " + caixa.ValorEntrada.ToString("C2");
               }

               _context.Caixa.Add(caixa);
               await _context.SaveChangesAsync();

               return CreatedAtAction("GetCaixa", new { id = caixa.CaixaId }, caixa);    
            } else if (caixa.TipoCaixaId == 6)
            {
                caixa.ValorEntrada = _context.Caixa.Where(c => c.DataCaixa.Date == caixa.DataCaixa.Date).Sum(c => c.ValorEntrada);
                caixa.ValorSaida = _context.Caixa.Where(c => c.DataCaixa.Date == caixa.DataCaixa.Date).Sum(c => c.ValorSaida);
                caixa.ValorAtual = caixa.ValorEntrada - caixa.ValorSaida;
                caixa.Descricao = "Fechamento do caixa no dia " + caixa.DataCaixa.ToShortDateString() + " com o Saldo: " + caixa.ValorAtual.ToString("C2");

                 _context.Caixa.Add(caixa);
               await _context.SaveChangesAsync();

               return CreatedAtAction("GetCaixa", new { id = caixa.CaixaId }, caixa);
            }             
            else {
                return Content("Não há saldo para essa saída de valores!");
            }

            
        }

        // DELETE: api/Caixa/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCaixa([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var caixa = await _context.Caixa.FindAsync(id);
            if (caixa == null)
            {
                return NotFound();
            }

            _context.Caixa.Remove(caixa);
            await _context.SaveChangesAsync();

            return Ok(caixa);
        }

        private bool CaixaExists(int id)
        {
            return _context.Caixa.Any(e => e.CaixaId == id);
        }

        private bool temSaldoParaSaida(DateTime data, Decimal valorSaida)
        {
            bool result = false;

            Caixa caixa = _context.Caixa.Where(c => c.DataCaixa.Date == data.Date).OrderByDescending(c => c.CaixaId).Take(1).FirstOrDefault();

            if (caixa != null && caixa.ValorAtual > 0 && caixa.ValorAtual > valorSaida)
            {
                result = true;
            }

            return result;
        }

        private Decimal SaldoAnterior(DateTime data){
            Decimal saldo = 0;
            
            Caixa caixa = _context.Caixa.Where(c => c.DataCaixa.Date == data.Date).OrderByDescending(c => c.CaixaId).Take(1).FirstOrDefault();
            if (caixa != null)
            {
               saldo = caixa.ValorAtual;    
            }            

            return saldo;
        }

        private Decimal SaldoAtual(DateTime data){
            Decimal saldo = 0;
            
            var entradas =  _context.Caixa.Where(c => c.DataCaixa.Date == data.Date).Sum(c => c.ValorEntrada);
            var saidas = _context.Caixa.Where(c => c.DataCaixa.Date == data.Date).Sum(c => c.ValorSaida);

            saldo = entradas - saidas;

            return saldo;
        }

        private bool estaAberto(DateTime data){
            bool resultado = false;
            
            bool abertura = _context.Caixa.Any(c => c.DataCaixa.Date == data.Date && c.TipoCaixaId == 1);
            bool fechamento = _context.Caixa.Any(c => c.DataCaixa.Date == data.Date && c.TipoCaixaId == 6);

            if (abertura && !fechamento)
            {
                resultado = true;
            } else if (abertura && fechamento)
            {
                resultado = false;
            } else if (!abertura && !fechamento)
            {
                resultado = false;
            }

            return resultado;
        }

        private bool estaFechado(DateTime data){
            bool resultado = false;
            
            bool abertura = _context.Caixa.Any(c => c.DataCaixa.Date == data.Date && c.TipoCaixaId == 1);
            bool fechamento = _context.Caixa.Any(c => c.DataCaixa.Date == data.Date && c.TipoCaixaId == 6);

            if (abertura && !fechamento)
            {
                resultado = false;
            } else if (abertura && fechamento)
            {
                resultado = true;
            } else if (!abertura && !fechamento)
            {
                resultado = false;
            }

            return resultado;
        }
    }
}