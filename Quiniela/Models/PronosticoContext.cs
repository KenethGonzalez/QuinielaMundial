using Microsoft.EntityFrameworkCore;

namespace Quiniela.Models
{
    public class PronosticoContext : DbContext
    {
        public PronosticoContext(DbContextOptions<PronosticoContext> options)
            : base(options)
        {
        }

        public DbSet<Pronostico> Pronosticos { get; set; } = null!;
    }
}
