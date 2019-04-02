using System;

namespace LocacaoEquipamentos.Dominio.Entidades
{
    public class Auditoria
    {
        public int AuditoriaId { get; set; }
        public string Usuario { get; set; }
        public string Acao { get; set; }
        public int NumeroContrato { get; set; }
        public int Adicional { get; set; }
        public DateTime GravadoEm { get; set; }
        public string Observacoes { get; set; }
    }
}