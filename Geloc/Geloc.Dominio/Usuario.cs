namespace Geloc.Dominio
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int Pin { get; set; }
        public int Ativo { get; set; }
    }
}