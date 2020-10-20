namespace PromotionEngine.Products
{
    public class ProductDetails
    {
        Model.Product product;
        public ProductDetails()
        {

        }
        public ProductDetails(Model.Product p)
        {
            product = p;
        }
        public long GetTotal()
        {
            return product.A.AAmount + product.B.BAmount +
               ((product.C.CAmount > 0 && product.C.CAmount == product.D.DAmount) ? 0 : product.C.CPrice * product.C.TotalUnit) +
              ((product.C.CAmount > 0 && product.C.CAmount == product.D.DAmount) ? product.D.DAmount : product.D.DPrice * product.D.TotalUnit);
        }
    }
}
