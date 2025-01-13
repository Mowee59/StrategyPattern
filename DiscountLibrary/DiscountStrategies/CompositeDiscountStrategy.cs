using DiscountLibrary.Interfaces;

namespace DiscountLibrary.DiscountStrategies
{
    public class CompositeDiscountStrategy : IDiscountStrategy
    {
        private readonly List<IDiscountStrategy> _strategies;

        public CompositeDiscountStrategy(List<IDiscountStrategy> strategies)
        {
            _strategies = strategies;
        }

        public decimal CalculateDiscount(decimal total)
        {
            foreach (var strategy in _strategies)
            {
                total = strategy.CalculateDiscount(total);
            }
            return total;
        }
    }
}
