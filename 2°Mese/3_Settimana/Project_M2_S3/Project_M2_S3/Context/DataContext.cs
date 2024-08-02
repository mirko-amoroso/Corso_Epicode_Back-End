using Microsoft.EntityFrameworkCore;
using Project_M2_S3.Models.Entity;

namespace Project_M2_S3.Context
{
    public class DataContext : DbContext
    {
        /// <summary>
        /// Prodotti.
        /// </summary>
        public virtual DbSet<Product> Products { get; set; }

        /// <summary>
        /// Ingredienti.
        /// </summary>
        public virtual DbSet<Ingredient> Ingredients { get; set; }

        /// <summary>
        /// Utenti.
        /// </summary>
        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<UserRole> UsersRoles { get; set; }

        /// <summary>
        /// Ruoli.
        /// </summary>
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<OrderItem> orderItems { get; set; }

        /// <summary>
        /// Ordini.
        /// </summary>
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<IngredienteProd> IngredientProduct { get; set; }

        public DataContext(DbContextOptions<DataContext> opt) : base(opt) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configura la chiave primaria composta per la tabella di relazione molti-a-molti
            modelBuilder.Entity<UserRole>()
                .HasKey(ur => new { ur.UserId, ur.RoleId });

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UsersRoles)
                .HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.Role)
                .WithMany(r => r.UsersRoles)
                .HasForeignKey(ur => ur.RoleId);

            modelBuilder.Entity<IngredienteProd>()
         .HasKey(ip => new { ip.ProductsId, ip.IngredientsId });

            modelBuilder.Entity<IngredienteProd>()
            .HasOne(ip => ip.Product)
            .WithMany(p => p.IngredienteProds)
            .HasForeignKey(ip => ip.ProductsId);

            modelBuilder.Entity<IngredienteProd>()
                .HasOne(ip => ip.Ingredient)
                .WithMany(i => i.IngredienteProds)
                .HasForeignKey(ip => ip.IngredientsId);
        }
    }
}
