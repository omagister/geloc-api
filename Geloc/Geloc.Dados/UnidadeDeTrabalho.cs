using Geloc.Dominio;
using System;

namespace Geloc.Dados
{
    public class UnidadeDeTrabalho : IDisposable
    {
        private Contexto _context = new Contexto();

        private RepositorioBase<Pessoa> _pessoaRepositorio;

        public RepositorioBase<Pessoa> PessoaRepositorio
        {
            get
            {
                if (this._pessoaRepositorio == null)
                {
                    this._pessoaRepositorio = new RepositorioBase<Pessoa>(_context);
                }

                return _pessoaRepositorio;
            }
        }

        private RepositorioBase<Endereco> _enderecoRepositorio;

        public RepositorioBase<Endereco> EnderecoRepositorio
        {
            get
            {
                if (this._enderecoRepositorio == null)
                {
                    this._enderecoRepositorio = new RepositorioBase<Endereco>(_context);
                }

                return _enderecoRepositorio;
            }
        }

        private RepositorioBase<Telefone> _telefoneRepositorio;

        public RepositorioBase<Telefone> TelefoneRepositorio
        {
            get
            {
                if (this._telefoneRepositorio == null)
                {
                    this._telefoneRepositorio = new RepositorioBase<Telefone>(_context);
                }

                return _telefoneRepositorio;
            }
        }

        private RepositorioBase<Email> _emailRepositorio;

        public RepositorioBase<Email> EmailRepositorio
        {
            get
            {
                if (this._emailRepositorio == null)
                {
                    this._emailRepositorio = new RepositorioBase<Email>(_context);
                }

                return _emailRepositorio;
            }
        }

        
        private RepositorioBase<Contrato> _contratoRepositorio;

        public RepositorioBase<Contrato> ContratoRepositorio
        {
            get
            {
                if (this._contratoRepositorio == null)
                {
                    this._contratoRepositorio = new RepositorioBase<Contrato>(_context);
                }

                return _contratoRepositorio;
            }
        }

        
        private RepositorioBase<CategoriaEquipamento> _categoriasEquipamentoRepositorio;

        public IRepositorioBase<CategoriaEquipamento> CategoriasEquipamentoRespositorio
        {
            get
            {
                if (this._categoriasEquipamentoRepositorio == null)
                {
                    this._categoriasEquipamentoRepositorio = new RepositorioBase<CategoriaEquipamento>(_context);
                }

                return _categoriasEquipamentoRepositorio;
            }
        }

        

        private RepositorioBase<ItemCategoriaContrato> _itensCategoriaContratoRepositorio;

        public IRepositorioBase<ItemCategoriaContrato> ItensCategoriaContratoRepositorio
        {
            get
            {
                if (this._itensCategoriaContratoRepositorio == null)
                {
                    this._itensCategoriaContratoRepositorio = new RepositorioBase<ItemCategoriaContrato>(_context);
                }

                return _itensCategoriaContratoRepositorio;
            }
        }

        private RepositorioBase<User> _userRepositorio;

        public IRepositorioBase<User> UserRepositorio
        {
            get
            {
                if (this._userRepositorio == null)
                {
                    this._userRepositorio = new RepositorioBase<User>(_context);
                }

                return _userRepositorio;
            }
        }


        private bool _disposed = false;

        public void Dispose()
        {
            Clear(true);
            GC.SuppressFinalize(this);
        }

        private void Clear(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        ~UnidadeDeTrabalho()
        {
            Clear(false);
        }
    }
}
