﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Model
{
    public class D : Product
    { 
        public D()
        {
            ProductName = "D";
            Price = 15;
            PromotionAmount = 30;
            PromotionUnit = 1;
        }
    }
}
