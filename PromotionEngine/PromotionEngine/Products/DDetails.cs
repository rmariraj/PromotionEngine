using PromotionEngine.Model;
using System;

namespace PromotionEngine.Products
{
    public class DDetails : ProductDetails
    {
        public DDetails()
        {
            this.product = new D();
        }

        //public override Product CalculateDetails()
        //{ 
        //    long Aamount = 0;
        //    long AnormalUnit = product.TotalUnit % product.PromotionUnit;
        //    Aamount = (product.TotalUnit / product.PromotionUnit) * product.PromotionAmount;
        //    product.Amount = Aamount + (AnormalUnit * product.Price);
        //    return product;
        //} 
    }
}
