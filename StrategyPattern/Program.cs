using System.Text;
using DiscountLibrary;
using DiscountLibrary.DiscountStrategies;

class Program
{
    static void Main(string[] args)
    {

        Console.OutputEncoding = Encoding.UTF8;

        

        // On demande un prix total
        Console.WriteLine("Entrez le prix total : ");
        decimal total = decimal.Parse(Console.ReadLine() ?? "0");

        // On créé deux stratégie
        var tenEurosDiscount = new FixedDiscountStrategy(10m); // Reduction fixe en euros
        var fiftyPercentDiscount = new PercentageDiscountStrategy(50m); // Reduction en pourcentages

        // On créé notre contexte qu'on initialise avec une stratégie
        var discountCalculator = new DiscountCalculator(tenEurosDiscount);

        // On execute la stratégie et on affiche le resultat
        decimal discountedPrice = discountCalculator.Calculate(total);
        Console.WriteLine($"Prix après réduction fixe de 10€ : {discountedPrice}");

        // On change de stratégie
        discountCalculator.SetDiscountStrategy(fiftyPercentDiscount);

        // On l'éxecute et on affiche le résultat
        discountedPrice = discountCalculator.Calculate(total);
        Console.WriteLine($"Prix après réduction de 50% : {discountedPrice}");
       

    }
}
