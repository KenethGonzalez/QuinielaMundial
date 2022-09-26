using Microsoft.EntityFrameworkCore;

namespace Quiniela.Models
{
    public class EquipoContext : DbContext
    {
        public EquipoContext(DbContextOptions<EquipoContext> options)
           : base(options)
        {
        }

        public DbSet<Equipo> Equipos { get; set; } = null!;
    }
}
