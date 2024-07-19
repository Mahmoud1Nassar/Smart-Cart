using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    public class Shop
    {
        private List<Product> products = new List<Product>();
        private ProductGenerator productGenerator = new ProductGenerator();

        public class GroceryStore
        {
            private List<Product> products = new List<Product>();
            private ProductGenerator productGenerator = new ProductGenerator();

            public GroceryStore()
            {
                
                for (int i = 0; i < 10; i++)
                {
                    products.Add(productGenerator.GenerateProduct());
                }
            }

            public void DisplayProducts()
            {
                Console.WriteLine("Available products in Grocery Store:");
                foreach (var product in products)
                {
                    Console.WriteLine(product);
                }
            }

            public Product SelectProduct(int index)
            {
                if (index < 0 || index >= products.Count)
                {
                    return null;
                }
                return products[index];
            }
        }

        public class ClothingStore
        {
            private List<Product> products = new List<Product>();
            private ProductGenerator productGenerator = new ProductGenerator();

            public ClothingStore()
            {
               
                for (int i = 0; i < 10; i++)
                {
                    products.Add(productGenerator.GenerateProduct());
                }
            }

            public void DisplayProducts()
            {
                Console.WriteLine("Available products in Clothing Store:");
                foreach (var product in products)
                {
                    Console.WriteLine(product);
                }
            }

            public Product SelectProduct(int index)
            {
                if (index < 0 || index >= products.Count)
                {
                    return null;
                }
                return products[index];
            }

        }
    }
}
