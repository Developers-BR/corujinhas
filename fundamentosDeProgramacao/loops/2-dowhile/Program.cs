
public class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Quantos devs precisam de café?");
        int devs = Convert.ToInt32(Console.ReadLine());

        int cafesPreparados = 0;

        do
        {
            cafesPreparados++;
            Console.WriteLine($"Preparando o {cafesPreparados}° café");
        } while (cafesPreparados < devs);

        if (cafesPreparados > devs)
        {
            Console.WriteLine($"Oh não! O café está esfriando e nenhum dev está por perto!");
        }
        else
        {
            Console.WriteLine($"Total de devs felizes: {cafesPreparados}");
        }

    }
}