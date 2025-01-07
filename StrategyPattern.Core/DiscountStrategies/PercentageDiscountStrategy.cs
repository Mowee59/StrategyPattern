
using DiscountLibrary.Interfaces;

namespace DiscountLibrary.DiscountStrategies
{
    public class PercentageDiscountStrategy : IDiscountStrategy
    {
        private readonly decimal _percentage;

        public PercentageDiscountStrategy(decimal percentage)
        {
            if (percentage > 100 || percentage < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(percentage), "Le pourcentage de reduction doit être en 0 et 100");
            }

            _percentage = percentage;
        }

        public decimal CalculateDiscount(decimal total)
        {
            return total * (1 - _percentage / 100);
        }
    }
}
