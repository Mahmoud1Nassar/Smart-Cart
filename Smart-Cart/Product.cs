using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ProductCategory Category { get; set; }
        public enum ProductCategory {
            Food,
            Clothing,
            Electronics,
            Makeup,
            Furniture
        }
        public Product(string name, decimal price, ProductCategory category) {
            Name = name;
            Price = price;
            Category = category;
        }
        public override string ToString() {
            return $"Name: {Name}, Price:{Price}";
        }
    }
}
