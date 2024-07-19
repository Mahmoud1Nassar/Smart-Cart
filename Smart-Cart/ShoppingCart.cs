using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Smart_Cart
{
    public class ShoppingCart
    {
       public List<Product> Cart = new List<Product>();

        public void AddItem(Product product) { 
            Cart.Add(product);
        }

        public void RemoveItem(Product product) {
            Cart.Remove(product);
        }

        public void DisplayCart() {
            foreach (var item in Cart)
            {
                Console.WriteLine(item);
            }
        }

        public string CalculateToalCost() {
            decimal total = 0;
            foreach (var item in Cart)
            {
                total += item.Price;
            }
            return $"Total Price: {total}";
        }

    }
}
