using animals;
public class Program
{
    private static readonly string filePath = "animals.txt";
    static void Main()
    {

        List<Talkable> zoo = new();
        AnimalInput animalInput = new(zoo);

        bool shouldGetInput = true;
        while (shouldGetInput)
        {
            animalInput.AddAnimal();
            Console.WriteLine("Add another animal? (Y/N)");
            string? input = Console.ReadLine();
            if (input == null || input == "" || !input.ToLower().StartsWith('y'))
            {
                shouldGetInput = false;
            }
        }

        WriteAnimals(zoo);
        ReadAnimals();
    }

    private static void ReadAnimals()
    {
        StreamReader sr = new(filePath);
        string? line;
        while ((line = sr.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
        sr.Close();
    }

    private static void WriteAnimals(List<Talkable> zoo)
    {
        StreamWriter sw = new(filePath);
        foreach (Talkable p in zoo)
        {
            Console.WriteLine($"{p.Name} says={p.Talk()}");
            sw.WriteLine($"{p.Name} | {p.Talk()}");
        }
        sw.Close();
    }
}
