

using DiscountLibrary.Interfaces;

namespace DiscountLibrary.DiscountStrategies
{
    public class FixedDiscountStrategy : IDiscountStrategy
    {
        private readonly decimal _fixedAmount;

        public FixedDiscountStrategy(decimal fixedAmount)
        {
            _fixedAmount = fixedAmount;
        }

        public decimal CalculateDiscount(decimal total)
        {
            return Math.Max(0, total - _fixedAmount); // On s'assure que le resultat ne soit pas inférieur à 0
        }
    }
}
