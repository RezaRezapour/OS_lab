

class Program
{
    private static List<Human> humans = new List<Human>();

    static void Main(string[] args)
    {
        humans = JsonUtility.LoadHumans();

        while (true)
        {
            Console.WriteLine("Enter 1 to add a human, 2 to save humans, or 3 to exi   , 4 to show humans, or");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    AddHuman();
                    break;
                case "2":
                    SaveHumans();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
                case "4":
                    ShowHumans();
                    break;
            }
        }
    }

    static void AddHuman()
    {
        Console.Write("Enter name: ");
        string personName = Console.ReadLine();
        Console.Write("Enter age: ");
        int personAge = int.Parse(Console.ReadLine());
        Console.Write("Enter address: ");
        string personAddress = Console.ReadLine();

        Human person = new Human
        {
            Name = personName,
            Age = personAge,
            Address = personAddress
        };

        humans.Add(person);
    }

    static void SaveHumans()
    {
        JsonUtility.SaveHumans(humans);
        Console.WriteLine("Humans saved to humans.json");
    }
    static void ShowHumans()
    {
        if (humans.Count == 0)
        {
            Console.WriteLine("No humans to show.");
        }
        else
        {
            Console.WriteLine("List of humans:");
            foreach (var human in humans)
            {
                Console.WriteLine($"Name: {human.Name}, Age: {human.Age}, Address: {human.Address}");
            }
        }
    }

}