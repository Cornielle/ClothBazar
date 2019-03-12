namespace ClothBazar.Entities
{
    public class Product : BaseEntity
    {
        public decimal Price { get; set; } = 0;
        public Category Category { get; set; }
    }
}
