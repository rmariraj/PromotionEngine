using PromotionEngine.Model;
using System;

namespace PromotionEngine.Products
{
    public class DDetails : ProductDetails
    { 
        Product product;
        public DDetails(Product product) : base(product)
        { 
            this.product = product;
            this.product.D = new D();
            product.D.TotalUnit = GetUnit();
            product.D.DAmount = CalculateADetails(product.D.TotalUnit);
        }

        private static long GetUnit()
        {
            Console.WriteLine("Enter the unit for D");
            string sUnit = Console.ReadLine();
            long totalUnit = !String.IsNullOrEmpty(sUnit) ? Convert.ToInt64(sUnit) : 0;
            return totalUnit;
        }

        private long CalculateADetails(long totalUnit)
        {
            long Damount = 0;
            long DnormalUnit = totalUnit % product.D.DPromotionUnit;
            Damount = (totalUnit / product.D.DPromotionUnit) * product.D.DPromotionAmount;
            return Damount + (DnormalUnit * product.D.DPrice);
        }
    }
}
