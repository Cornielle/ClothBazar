using System.ComponentModel.DataAnnotations;

namespace ClothBazar.Entities
{
    public class Product : BaseEntity
    {
        [Key]
        public int id { get; set; }
        public decimal Price { get; set; } = 0;
        public Category Category { get; set; }
    }
}
