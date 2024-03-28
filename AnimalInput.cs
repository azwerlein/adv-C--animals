using animals;

public class AnimalInput
{
    private readonly List<Talkable> _animals;
    public AnimalInput(List<Talkable> zoo)
    {
        _animals = zoo;
    }

    public void AddAnimal()
    {
        Talkable? animal = GetAnimalInput();
        if (animal != null)
        {
            _animals.Add(animal);
        }
    }

    private Talkable GetAnimalInput()
    {
        while (true)
        {
            Console.WriteLine("Please enter the number of the animal you want to create.");
            Console.WriteLine("1. Cat \n2. Dog \n3. Teacher ");
            try
            {
                int animal = int.Parse(Console.ReadLine());
                switch (animal)
                {
                    case 1:
                        return MakeCat();
                    case 2:
                        return MakeDog();
                    case 3:
                        return MakeTeacher();
                    default:
                        Console.WriteLine("Error: Number entered does not match any of the choices.");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Error: Not a real number. Please enter one of the numbers listed.");
            }
        }
    }

    private Cat MakeCat()
    {
        string name = GetName();
        int miceKilled = GetMiceKilled();
        return new Cat(miceKilled, name);
    }

    private Dog MakeDog()
    {
        string name = GetName();
        bool friendly = GetFriendliness();
        return new Dog(friendly, name);
    }

    private Teacher MakeTeacher()
    {
        string name = GetName();
        int age = GetAge();

        return new Teacher(age, name);
    }

    private string GetName()
    {
        while (true)
        {
            Console.WriteLine("Please enter the name: ");
            string? name = Console.ReadLine();
            if (name == null || name == "")
            {
                Console.WriteLine("Names cannot be empty. Please try again.");
            }
            else
            {
                return name;
            }
        }
    }

    private bool GetFriendliness()
    {
        while (true)
        {
            Console.WriteLine("Is the dog friendly? (Y/N)");
            string? input = Console.ReadLine();
            if (input == null || input == "")
            {
                Console.WriteLine("Input cannot be empty. Please try again.");
            }
            else if (input.ToLower().StartsWith('y'))
            {
                return true;
            }
            else if (input.ToLower().StartsWith('n'))
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid response. Enter Y for yes or N for no.");
            }
        }
    }

    private int GetMiceKilled()
    {
        return QueryForPositiveNumber("Enter the number of mice killed: ");
    }

    private int GetAge()
    {
        return QueryForPositiveNumber("Enter the age of the teacher: ");
    }

    private int QueryForPositiveNumber(string prompt)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            try 
            {
                int input = int.Parse(Console.ReadLine());
                if (input < 0)
                {
                    Console.WriteLine("Error: Please enter a non-negative number.");
                }
                else
                {
                    return input;
                }
            }
            catch
            {
                Console.WriteLine("Error: Please enter a real number.");
            }
        }
    }
}
