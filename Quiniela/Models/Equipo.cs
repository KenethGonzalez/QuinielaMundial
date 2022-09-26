namespace Quiniela.Models
{
    public class Equipo
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }    
        public int IdGrupo { get; set; }
        public int IdSede { get; set; }
    }
}
