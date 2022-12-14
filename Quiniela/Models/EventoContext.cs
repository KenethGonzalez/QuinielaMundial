using Microsoft.EntityFrameworkCore;

namespace Quiniela.Models
{
    public class EventoContext : DbContext
    {
        public EventoContext(DbContextOptions<EventoContext> options)
            : base(options)
        {
        }

        public DbSet<Evento> Eventos { get; set; } = null!;
    }
}
