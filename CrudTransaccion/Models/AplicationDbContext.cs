using Microsoft.EntityFrameworkCore;

namespace CrudTransaccion.Models
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Cargo> Roles { get; set; }
        public DbSet<Empresa> Empresas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Transaccional;Trusted_Connection=true;Encrypt=false;");
        }

    }
}
}
