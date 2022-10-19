using Inlämningsuppgift;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Hej i våra Sem Butik");
        Console.WriteLine("Vi befinner oss på Hölmvähen 22, våra faktureing addres är Hjortvägen 23.");

        ItemAdder itemAdder = new ItemAdder();
        List<Mug> mugs = new List<Mug>(itemAdder.SortMugs(itemAdder.GetMugs()));

        Console.WriteLine("\nVåra muggar lista-:");
        foreach (Mug mug in mugs)
        {
            Console.WriteLine( $"Muggar typer: {mug.Typ}\nMuggar motviver: {mug.Motiv}\nMuggar priset: {mug.Pris} Sek \nMuggar snittbetyg: {mug.Snittbetyg}\n");
        }

        List<Tshirt> tshirts = new List<Tshirt>(itemAdder.SortShirts(itemAdder.GetTshirt()));

        Console.WriteLine("\nVåra tisher lista :-");
        foreach (Tshirt tshirt in tshirts)
        {
            Console.WriteLine($"Tshirt Motiv: {tshirt.Motiv}\nTshirt storlek: {tshirt.Storlek}\nTishirt material: {tshirt.Material}\nTishirt peris: {tshirt.Pris} Sek \nTishirt betyg: {tshirt.Snittbetyg}\n");
        }
        
        Console.WriteLine(itemAdder.GetTshirt);
        Console.ReadLine();
    }
}