namespace PromotionEngine.Model
{
    public class B : Product
    {
        public long BPrice { get; set; }
        public long BPromotionAmount { get; set; }
        public long BPromotionUnit { get; set; }
        public long BAmount { get; set; }
        public B()
        {
            this.BPrice = 30;
            this.BPromotionAmount = 45;
            this.BPromotionUnit = 2;
        }
    }
}
