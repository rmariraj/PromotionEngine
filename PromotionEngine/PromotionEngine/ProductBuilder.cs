using PromotionEngine.Model;
using PromotionEngine.Products;
using System.Linq;

namespace PromotionEngine
{
    class ProductBuilder : Product
    {
        Cart Cart = null;
        long TotalPrice = 0;
        ProductDetails productDetails = null;
        public ProductBuilder()
        {
            Cart = new Cart();
        }
        public long GetTotalPrice()
        {
            var CProduct = Cart.product.Where(x => x.ProductName == "C").FirstOrDefault();
            var DProduct = Cart.product.Where(x => x.ProductName == "D").FirstOrDefault();

            Cart.product.Where(x => x.ProductName == "C" && x.Unit > 0)
                .Select(w => w.Amount = (CProduct.Unit == DProduct.Unit ? 0 : w.Price * w.Unit)).ToList();

            Cart.product.Where(x => x.ProductName == "D" && x.Unit > 0)
              .Select(w => w.Amount = (CProduct.Unit == DProduct.Unit ? w.PromotionAmount * w.Unit : w.Price * w.Unit)).ToList();

            TotalPrice = Cart.product.Sum(x => x.Amount);

            return TotalPrice;
        }
        public void Builder(string ProductName)
        {
            productDetails = CreateObject(ProductName);
            productDetails.GetUnit(ProductName);
            var obj = productDetails.CalculateDetails();
            Cart.product.Add(obj);
        }

        private ProductDetails CreateObject(string ProductName)
        {
            switch (ProductName)
            {
                case "A":
                    return new ADetails();
                case "B":
                    return new BDetails();
                case "C":
                    return new CDetails();
                case "D":
                    return new DDetails();
                default:
                    break;
            }
            return null;
        }
    }
}
