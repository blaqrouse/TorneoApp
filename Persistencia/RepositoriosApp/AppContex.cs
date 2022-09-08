using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Persistencia 
{
    public class AppContex:DbContext
    {
        public DbSet<Municipio> Municipios {get;set;}
        public DbSet<Patrocinador> Patrocinadores {get;set;}
        public DbSet<Colegio> Colegios {get;set;}
        public DbSEt<Torneo> Torneos {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-1MQT9DG; Initial Catalog=Aplicacion; Integrated Security=True ");
            }
        }
    }
}