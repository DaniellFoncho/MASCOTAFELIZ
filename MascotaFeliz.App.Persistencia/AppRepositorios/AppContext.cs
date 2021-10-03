using Microsoft.EntityFrameworkCore;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Mascota> Mascota {get;set;} 
        public DbSet<Veterinario> Veterinario {get;set;} 
        public DbSet<Propietario> Propietario {get;set;} 
        public DbSet<Visita> Visita {get;set;} 
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {       
            if(!optionsBuilder.IsConfigured) 
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =MascotaFeliztData");
            }
        } 

    } 

}