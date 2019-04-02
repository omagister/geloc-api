namespace LocacaoEquipamentos.Dominio.Entidades
{
    public class Email
    {
        public int EmailId { get; set; }
        public string endereco { get; set; }
        public int Ativo { get; set; }
        public int PessoaId { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
