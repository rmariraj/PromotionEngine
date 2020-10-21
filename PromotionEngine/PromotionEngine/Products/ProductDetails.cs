using PromotionEngine.Model;
using System;

namespace PromotionEngine.Products
{
    public abstract class ProductDetails
    {
        public Product product;
        public Cart Cart;
        public Product GetUnit(string className)
        {
            Console.WriteLine("Enter the unit for {0}", className);
            string sUnit = Console.ReadLine();
            long totalUnit = !String.IsNullOrEmpty(sUnit) ? Convert.ToInt64(sUnit) : 0;
            product.Unit = totalUnit;
            return product;
        }
        public long GetTotal()
        {
            return product.Amount;
        }
        public virtual Product CalculateDetails()
        {
            long Aamount = 0;
            long AnormalUnit = product.Unit % product.PromotionUnit;
            Aamount = (product.Unit / product.PromotionUnit) * product.PromotionAmount;
            product.Amount = Aamount + (AnormalUnit * product.Price);
            return product;
        }
    }
}
