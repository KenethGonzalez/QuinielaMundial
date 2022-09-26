namespace Quiniela.Models
{
    public class Pronostico
    {
        public int Id { get; set; }
        public int IdQuiniela { get; set; }
        public int IdJornada { get; set; }
        public int IdEvento { get; set; }
        public string? Pronos { get; set; }
    }
}
