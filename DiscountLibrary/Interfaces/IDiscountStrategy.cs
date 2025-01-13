

namespace DiscountLibrary.Interfaces
{
    public interface IDiscountStrategy
    {
        decimal CalculateDiscount(decimal total);
    }
}
