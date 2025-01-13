using System.Text;
using DiscountLibrary;
using DiscountLibrary.DiscountStrategies;
using DiscountLibrary.Interfaces;

class Program
{
    static void Main(string[] args)
    {

        Console.OutputEncoding = Encoding.UTF8;

        

        // On demande un prix total
        Console.WriteLine("Entrez le prix total : ");
        decimal total = decimal.Parse(Console.ReadLine() ?? "0");

        // On créé les stratégies
        var tenEurosDiscount = new FixedDiscountStrategy(10m); // Reduction fixe en euros
        var fiftyPercentDiscount = new PercentageDiscountStrategy(50m); // Reduction en pourcentages
        var thresholdDdiscount = new ThresholdDiscountStrategy(100, 5); // Reduction de 5€ a partir de 100€ d'achat
        // Reduction qui combine toutes les reductiosn précédentes dans l'ordre
        var compositeDiscount = new CompositeDiscountStrategy(new List<IDiscountStrategy> { tenEurosDiscount, fiftyPercentDiscount, thresholdDdiscount });

        // On créé notre contexte qu'on initialise avec une stratégie
        var discountCalculator = new DiscountCalculator(tenEurosDiscount);

        // On execute la stratégie et on affiche le resultat
        decimal discountedPrice = discountCalculator.Calculate(total);
        Console.WriteLine($"Prix après réduction fixe de 10€ : {discountedPrice} €");

        // On change de stratégie pour la reduction de 50%
        discountCalculator.SetDiscountStrategy(fiftyPercentDiscount);

        // On l'éxecute et on affiche le résultat
        discountedPrice = discountCalculator.Calculate(total);
        Console.WriteLine($"Prix après réduction de 50% : {discountedPrice} €");

        // On change de stratégie pour la reduction avec seuil
        discountCalculator.SetDiscountStrategy(thresholdDdiscount);

        // On l'éxecute et on affiche le résultat
        discountedPrice = discountCalculator.Calculate(total);
        Console.WriteLine($"Prix après réduction de 5€ à partirt de 100€ d'achat : {discountedPrice} €");


        // On change la stratégie pour la stratégie de reduction combinée
        discountCalculator.SetDiscountStrategy(compositeDiscount);

        // On l'execute et on affiche le resultat
        discountedPrice = discountCalculator.Calculate(total);
        Console.WriteLine($"Prix après les réductions combinées : {discountedPrice} €");




        Console.ReadLine();

    }
}
