using System;
using static Smart_Cart.Shop;

namespace Smart_Cart
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            GroceryStore groceryStore = new GroceryStore();
            ClothingStore clothingStore = new ClothingStore();

            bool shopping = true;

            while (shopping)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Shop at Grocery Store");
                Console.WriteLine("2. Shop at Clothing Store");
                Console.WriteLine("3. View Shopping Cart");
                Console.WriteLine("4. Calculate Total Cost");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        groceryStore.DisplayProducts();
                        Console.WriteLine("Enter the product number to add to the cart:");
                        if (int.TryParse(Console.ReadLine(), out int groceryIndex))
                        {
                            var product = groceryStore.SelectProduct(groceryIndex);
                            if (product != null)
                            {
                                cart.AddItem(product);
                                Console.WriteLine("Product added to the cart.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid product number.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }
                        break;
                    case "2":
                        clothingStore.DisplayProducts();
                        Console.WriteLine("Enter the product number to add to the cart:");
                        if (int.TryParse(Console.ReadLine(), out int clothingIndex))
                        {
                            var product = clothingStore.SelectProduct(clothingIndex);
                            if (product != null)
                            {
                                cart.AddItem(product);
                                Console.WriteLine("Product added to the cart.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid product number.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }
                        break;
                    case "3":
                        cart.DisplayCart();
                        break;
                    case "4":
                        Console.WriteLine(cart.CalculateToalCost());
                        break;
                    case "5":
                        shopping = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
