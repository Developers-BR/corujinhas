public class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Quantos devs precisam de café?");
        int devs = Convert.ToInt32(Console.ReadLine());

        int cafesPreparados = 0;

        for (int i = 0; i < devs; i++)
        {
            Console.WriteLine($"Preparando o {i}° café");

            cafesPreparados = i;
        }

        Console.WriteLine($"Total de devs felizes: {cafesPreparados}");

    }
}