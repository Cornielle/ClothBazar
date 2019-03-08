using ClothBazar.Entities;
using System.Data.Entity;

namespace ClothBazar.Database
{
    public class CBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
