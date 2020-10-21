using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Model
{
    public class Product
    {
        public string ProductName { get; set; }
        public long Unit { get; set; }
        public long Price { get; set; }
        public long PromotionAmount { get; set; }
        public long PromotionUnit { get; set; }
        public long Amount { get; set; }
    }
}
