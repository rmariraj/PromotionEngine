namespace PromotionEngine.Model
{
    public class A : Product
    {

        public long APrice { get; set; }
        public long APromotionAmount { get; set; }
        public long APromotionUnit { get; set; }
        public long AAmount { get; set; }
        public A()
        {
            this.APrice = 50;
            this.APromotionAmount = 130;
            this.APromotionUnit = 3;
        }
    }
}
