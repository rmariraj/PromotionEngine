using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Model
{
    public class D : Product
    {
        public long DPrice { get; set; } 
        public long DPromotionAmount { get; set; }  
        public long DPromotionUnit { get; set; } 
        public long DAmount { get; set; }
        public D()
        {
            this.DPrice = 15;
            this.DPromotionAmount = 30;
            this.DPromotionUnit = 1;
        }
    }
}
