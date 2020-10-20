using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Model
{
    public class C : Product
    {
        public long CPrice { get; set; } 
        public long CPromotionAmount { get; set; }  
        public long CPromotionUnit { get; set; } 
        public long CAmount { get; set; }
        public C()
        {
            this.CPrice = 20;
            this.CPromotionAmount = 30;
            this.CPromotionUnit = 1;
        }
    }
}
