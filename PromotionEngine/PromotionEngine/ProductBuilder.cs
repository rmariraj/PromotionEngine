using PromotionEngine.Model;
using PromotionEngine.Products;

namespace PromotionEngine
{
    class ProductBuilder
    {
        public static void Builder(ProductDetails productDetails, Product product)
        {
            CreateObject("A", product);
            CreateObject("B", product);
            CreateObject("C", product);
            CreateObject("D", product);
        }

        private static ProductDetails CreateObject(string ProductName, Product p)
        {
            switch (ProductName)
            {
                case "A":
                    return new ADetails(p);
                case "B":
                    return new BDetails(p);
                case "C":
                    return new CDetails(p);
                case "D":
                    return new DDetails(p);
                default:
                    break;
            }
            return null;
        }
    }
}
