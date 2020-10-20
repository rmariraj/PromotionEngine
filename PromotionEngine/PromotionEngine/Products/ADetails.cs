using PromotionEngine.Model;
using System;

namespace PromotionEngine.Products
{
    public class ADetails : ProductDetails
    { 
        Product product;
        public ADetails(Product product) : base(product)
        {
            this.product = product;
            this.product.A = new A();
            product.A.TotalUnit = GetUnit();
            product.A.AAmount = CalculateADetails(product.A.TotalUnit);
        }

        private static long GetUnit()
        {
            Console.WriteLine("Enter the unit for A");
            string sUnit = Console.ReadLine();
            long totalUnit = !String.IsNullOrEmpty(sUnit) ? Convert.ToInt64(sUnit) : 0;
            return totalUnit;
        }

        public long CalculateADetails(long totalUnit)
        {
            long Aamount = 0;
            long AnormalUnit = totalUnit % product.A.APromotionUnit;
            Aamount = (totalUnit / product.A.APromotionUnit) * product.A.APromotionAmount;
            return Aamount + (AnormalUnit * product.A.APrice);
        }
    }
}
