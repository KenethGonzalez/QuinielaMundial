using Microsoft.EntityFrameworkCore;

namespace Quiniela.Models
{
    public class EstadioContext : DbContext
    {
        public EstadioContext(DbContextOptions<EstadioContext> options)
            : base(options)
        {
        }

        public DbSet<Estadio> Estadios { get; set; } = null!;
    }
}
