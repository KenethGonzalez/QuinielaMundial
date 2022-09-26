using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Quiniela.Models
{
    public class SedeContext : DbContext
    {
        public SedeContext(DbContextOptions<SedeContext> options)
            : base(options)
        {
        }

        public DbSet<Sede> Sedes { get; set; } = null!;
    }
}
