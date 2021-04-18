using System;
using System.Collections.Generic;

namespace Delegates
{
    class Program
    {
        static ShoppingCartModel cart = new ShoppingCartModel();
        public static void Main(string[] args)
        {
            PopulateCartWithDemoCart();

            Console.WriteLine($"The total for the cart is {cart.GenerateTotal(SubtotalAlert, CalculateLeveledDiscount, AlertUser):C2}");

            Console.WriteLine();

        }

        private static void SubtotalAlert(decimal subTotal)
        {
            Console.WriteLine($"The subtotal is {subTotal:C2}");
        }

        private static void AlertUser(string message)
        {
            Console.WriteLine($"{message}");
        }

        private static decimal CalculateLeveledDiscount(List<ProductModel> items, decimal subTotal)
        {
            if (subTotal > 100)
            {
                return subTotal * 0.80M;
            }
            else if (subTotal > 50)
            {
                return subTotal * 0.85M;
            }
            else if (subTotal > 10)
            {
                return subTotal * 0.90M;
            }
            else
            {
                return subTotal;
            }
        }

        private static void PopulateCartWithDemoCart()
        {
            cart.items.Add(new ProductModel { ItemName = "cereal", Price = 3.63M });
            cart.items.Add(new ProductModel { ItemName = "milk", Price = 2.95M });
            cart.items.Add(new ProductModel { ItemName = "strawberries", Price = 7.51M });
            cart.items.Add(new ProductModel { ItemName = "blueberries", Price = 8.48M });
        }
    }
}
