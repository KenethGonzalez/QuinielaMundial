using Microsoft.EntityFrameworkCore;

namespace Quiniela.Models
{
    public class JornadaContext : DbContext
    {
        public JornadaContext(DbContextOptions<JornadaContext> options)
            : base(options)
        {
        }

        public DbSet<Jornada> Jornadas { get; set; } = null!;
    }
}
