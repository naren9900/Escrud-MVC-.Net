using Microsoft.EntityFrameworkCore;
using proyectoMVC.Models;

namespace proyectoMVC.Data
{
    public class ProyectoMvcDbContext : DbContext
    {
        public DbSet<Taller> Tallers { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Vehiculo> Vehiculos { get; set; }

        public ProyectoMvcDbContext(DbContextOptions<ProyectoMvcDbContext> options) : base(options)
        {

        }
    }
}
