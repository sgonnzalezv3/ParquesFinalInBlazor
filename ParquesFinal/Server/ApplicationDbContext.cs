using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ParquesFinal.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParquesFinal.Server
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ParqueIlicito>().HasKey(x => new { x.ActividadIlicitaId, x.ParqueId });
            modelBuilder.Entity<ParqueEcosistema>().HasKey(x => new { x.EcosistemaId, x.ParqueId });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<ParqueIlicito> ParqueIlicitos { get; set; }
        public DbSet<Parque> Parques { get; set; }
        public DbSet<ActividadIlicita> ActividadesIlicitas { get; set; }
        public DbSet<ParqueEcosistema>ParqueEcosistemas { get; set; }
        public DbSet<Ecosistema>Ecosistemas { get; set; }
        public DbSet<ZonaAlojamiento>ZonasDeAlojamiento { get; set; }
        public DbSet<Car>Cars { get; set; }
        public DbSet<Personal> Personales { get; set; }
        public DbSet<Visitante> Visitantes { get; set; }

        



        
    }
}
