using PromotionEngine.Model;
using System;

namespace PromotionEngine.Products
{

    public class CDetails : ProductDetails
    { 
        Product product;
        public CDetails(Product product) : base(product)
        { 
            this.product = product;
            this.product.C = new C();
            product.C.TotalUnit = GetUnit();
            product.C.CAmount = CalculateADetails(product.C.TotalUnit);
        }

        private static long GetUnit()
        {
            Console.WriteLine("Enter the unit for C");
            string sUnit = Console.ReadLine();
            long totalUnit = !String.IsNullOrEmpty(sUnit) ? Convert.ToInt64(sUnit) : 0;
            return totalUnit;
        }

        public long CalculateADetails(long totalUnit)
        {
            long Camount = 0;
            long CnormalUnit = totalUnit % product.C.CPromotionUnit;
            Camount = (totalUnit / product.C.CPromotionUnit) * product.C.CPromotionAmount;
            return Camount + (CnormalUnit * product.C.CPrice);
        }
    }
}
