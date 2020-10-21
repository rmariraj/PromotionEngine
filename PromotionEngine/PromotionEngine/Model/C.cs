using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Model
{
    public class C : Product
    { 
        public C()
        {
            ProductName = "C";
            Price = 20;
            PromotionAmount = 30;
            PromotionUnit = 1;
        }
    }
}
