using PromotionEngine.Model;
using System;

namespace PromotionEngine.Products
{
    public class BDetails : ProductDetails
    { 
        Product product;
        public BDetails(Product product) : base(product)
        { 
            this.product = product;
            this.product.B = new B();
            product.B.TotalUnit = GetUnit();
            product.B.BAmount = CalculateADetails(product.B.TotalUnit);
        }

        private static long GetUnit()
        {
            Console.WriteLine("Enter the unit for B");
            string sUnit = Console.ReadLine();
            long totalUnit = !String.IsNullOrEmpty(sUnit) ? Convert.ToInt64(sUnit) : 0;
            return totalUnit;
        }

        private long CalculateADetails(long totalUnit)
        {
            long Bamount = 0;
            long BnormalUnit = totalUnit % product.B.BPromotionUnit;
            Bamount = (totalUnit / product.B.BPromotionUnit) * product.B.BPromotionAmount;
            return Bamount + (BnormalUnit * product.B.BPrice);
        }
    }
}
