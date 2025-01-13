
using DiscountLibrary.Interfaces;

namespace DiscountLibrary.DiscountStrategies
{
    public class ThresholdDiscountStrategy : IDiscountStrategy
    {
        private readonly decimal _threshold;
        private readonly decimal _flatDiscount;

        public ThresholdDiscountStrategy(decimal threshold, decimal flatDiscount)
        {
            _threshold = threshold;
            _flatDiscount = flatDiscount;
        }

        public decimal CalculateDiscount(decimal total)
        {
            return total >= _threshold ? total - _flatDiscount : total;
        }
    }

}
