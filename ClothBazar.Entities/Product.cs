using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Entities
{
    public class Product : BaseEntity
    {
        public int id { get; set; }
        public decimal Price { get; set; } = 0;
        public Category Category { get; set; }
    }
}
