using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    public class ProductGenerator
    {
        private static readonly Random random = new Random();
        private readonly string[] productName = { "Apple", "Banana", "T-Shirt", "Laptop", "Lipstick", "Sofa" };

        public Product GenerateProduct() {
            string name = productName[random.Next(productName.Length)];
            decimal price = Math.Round((decimal)(random.NextDouble() * 100) , 2);
            Product.ProductCategory category = (Product.ProductCategory)random.Next(Enum.GetValues(typeof(Product.ProductCategory)).Length);
            return new Product(name, price, category);
        }
    }

}
