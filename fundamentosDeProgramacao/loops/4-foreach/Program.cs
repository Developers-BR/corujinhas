public class Program
{
    private static void Main(string[] args)
    {

        var developers = new List<string>();
        string maisdevs = "s";

        do
        {
            Console.WriteLine("Digite o nome do dev:");
            developers.Add(Console.ReadLine() as string ?? string.Empty);

            Console.WriteLine("Mais algum dev precisa de café? [S/N]");
            maisdevs = Console.ReadLine() as string ?? string.Empty;

        } while (maisdevs.ToLower().Equals("s"));

        foreach (var dev in developers)
        {
            Console.WriteLine($"Preparando café para o dev {dev}");
        }

        Console.WriteLine($"Total de devs felizes: {developers.Count}");

    }
}