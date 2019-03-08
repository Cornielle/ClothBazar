using ClothBazar.Entities;
using System.Data.Entity;

namespace ClothBazar.Database
{
    public class CBContext : DbContext
    {
        public CBContext()
            :base("ClothBazarConnection")
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
