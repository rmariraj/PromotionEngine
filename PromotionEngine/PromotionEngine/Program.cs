using PromotionEngine.Model;
using PromotionEngine.Products;
using System;


namespace PromotionEngine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product product = new Product();
            ProductBuilder<Product> productBuilder = new ProductBuilder<Product>();
            //ProductDetails productDetails;// = new ProductDetails(product);
            Console.WriteLine("Enter Total number of order");
            int TotalOrders = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < TotalOrders; i++)
            {
                productBuilder.Builder("A");
                productBuilder.Builder("B");
                productBuilder.Builder("C");
                productBuilder.Builder("D");
                Console.WriteLine(productBuilder.GetTotalPrice());
            }
            Console.ReadLine();
        }
    }
}