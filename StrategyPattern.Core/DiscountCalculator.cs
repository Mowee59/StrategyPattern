using DiscountLibrary.Interfaces;

namespace DiscountLibrary
{
    public class DiscountCalculator
    {
        // Reference vers la stratégie actuelle
        private IDiscountStrategy _strategy;


        public DiscountCalculator(IDiscountStrategy strategy)
        {
            _strategy = strategy;
        }

        // Permet de changer de stratégie
        public void SetDiscountStrategy(IDiscountStrategy strategy)
        {
            _strategy = strategy;
        }

        // Déclenche l'éxécution de la stratégie
        public decimal Calculate(decimal total)
        {
            return _strategy.CalculateDiscount(total);
        }
    }
}
