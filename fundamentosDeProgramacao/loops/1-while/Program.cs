public class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Quantos devs precisam de café?");
        int devs = Convert.ToInt32(Console.ReadLine());

        int cafesPreparados = 0;

        while (cafesPreparados < devs)
        {
            cafesPreparados++;
            Console.WriteLine($"Preparando o {cafesPreparados}° café");
        }

        Console.WriteLine($"Total de devs felizes: {cafesPreparados}");

    }
}