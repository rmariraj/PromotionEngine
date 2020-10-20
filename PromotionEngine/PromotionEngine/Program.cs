using PromotionEngine.Model;
using PromotionEngine.Products;
using System;


namespace PromotionEngine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            long TotalPrice = 0;
            Product product = new Product();
            ProductBuilder productBuilder = new ProductBuilder();
            ProductDetails productDetails = new ProductDetails(product);
            Console.WriteLine("Enter Total number of order");
            int TotalOrders = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < TotalOrders; i++)
            {
                ProductBuilder.Builder(productDetails, product);
                TotalPrice = productDetails.GetTotal();
                Console.WriteLine(TotalPrice);
            }
            Console.ReadLine();
        }
    }
}