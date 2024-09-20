using backend_D_D.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;

namespace backend_D_D.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
          : base(options)
        {
        }

        public DbSet<Personaggio> Personaggio { get; set; }
        public DbSet<Background> Backgound { get; set; }
        public DbSet<Classi> Classi { get; set; }
        public DbSet<Utente> Utente { get; set; }
        public DbSet<Armatura> Armatura { get; set; }
        public DbSet<Armi> Armi { get; set; }
        public DbSet<Inventario> Inventario { get; set; }
        public DbSet<Tiri_Salvezza> Tiri_Salvezza { get; set; }
        public DbSet<Abilita> Abilita { get; set; }
        public DbSet<Attributi> Attributi { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Utente>()
                .HasIndex(u => u.Email)
                .IsUnique();

            base.OnModelCreating(modelBuilder);
        }
    }
}
