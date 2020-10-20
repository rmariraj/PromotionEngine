using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Model
{
    public class Product
    {
        public long TotalUnit { get; set; }
        public virtual A A { get; set; }
        public virtual B B { get; set; }
        public virtual C C { get; set; }
        public virtual D D { get; set; }
    }
}
