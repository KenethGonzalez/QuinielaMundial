namespace Quiniela.Models
{
    public class Evento
    {
        public int Id { get; set; }

        public int IdJornada { get; set; }
        public int IdEquipoLocal { get; set; }
        public int IdEquipoVisitante { get; set; }
        public string? Resultado { get; set; }

    }
}
