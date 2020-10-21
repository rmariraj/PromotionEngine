using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Model
{
    public class Cart
    {
        public List<Product> product { get; set; }
        public Cart()
        {
            product = new List<Product>();
        }
    }
}
