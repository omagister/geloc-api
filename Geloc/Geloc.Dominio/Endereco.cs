namespace Geloc.Dominio
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string CEP { get; set; }
        public string Uf { get; set; }
        public int Ativo { get; set; }
        public int PessoaId { get; set; }
        public string Referencia { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
