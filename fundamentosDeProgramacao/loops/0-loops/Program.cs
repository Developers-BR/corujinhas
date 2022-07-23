public class Program
{
    private static void Main(string[] args)
    {

        int cafesPreparados = 0;

        // Preparando o café
        cafesPreparados++;
        Console.WriteLine($"Preparando o 1° café");

        cafesPreparados++;
        Console.WriteLine($"Preparando o 2° café");

        cafesPreparados++;
        Console.WriteLine($"Preparando o 3° café");

        Console.WriteLine($"Total de devs felizes: {cafesPreparados}");
    }
}