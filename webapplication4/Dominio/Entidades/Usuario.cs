namespace Dominio.Entidades
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public int Ativo { get; set; }
        

        public bool UsuarioAtivo()
        {
            bool situacao = Ativo == 1;

            return situacao;
        }
    }
}
