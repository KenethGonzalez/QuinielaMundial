using Microsoft.EntityFrameworkCore;

namespace Quiniela.Models
{
    public class GrupoContext : DbContext
    {
        public GrupoContext(DbContextOptions<GrupoContext> options)
           : base(options)
        {
        }

        public DbSet<Grupo> Grupos { get; set; } = null!;
    }
}
