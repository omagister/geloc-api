using System;

namespace Geloc.Api.QueryParams
{
    public class CaixaQueryParams
    {
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public int TipoCaixaId { get; set; }
        public int TipoEntradaCaixaId { get; set; }
        public int TipoContaId { get; set; }
    }
}