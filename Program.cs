string userInput = "0";
Random random = new Random();

while (userInput != "4")
{
    DisplayMenu();
    userInput = GetUserChoice();

    switch (userInput)
    {
        case "1":
        DisplayPlainPizza(random.Next(8,13));
        Console.ReadLine();
        break;

        case "2":
        DisplayCheesePizza(random.Next(8,13));
        Console.ReadLine();
        break;

        case "3":
        DisplayPepperoniPizza(random, random.Next(8,13));
        Console.ReadLine();
        break;

        case "4":
        Console.WriteLine("Hope you enjoyed your pizza!");
        break;

        default:
        System.Console.WriteLine("Invalid. Please choose 1, 2, 3, or 4");
        break;
    }
}

static void DisplayMenu()
    {
    Console.Clear();
    System.Console.WriteLine("1. Display plain pizza\n2. Display cheese pizza \n3. Display pepperoni pizza \n4. Exit");
    }

static string GetUserChoice()
    {
        Console.WriteLine("Choose one of the following numbers");
        return Console.ReadLine() ??"";
    }

static void DisplayPlainPizza(int rows)
{
    Console.Clear();
    for(int i = rows; i > 0; i--)
    {
        Console.WriteLine(new string('*', i));
    }
    Pause();
}

static void DisplayCheesePizza(int rows)
{
    Console.Clear();
    Console.WriteLine(new string('*', rows));
    for (int i = rows - 1; i > 0; i--)
    {
        Console.Write('*');
        if (i > 1)
        {
            Console.Write(new string ('#', i - 2));
            Console.Write('*');
        }
        else
        {
            Console.WriteLine(' ');
        }
        Console.WriteLine();
    }
    Pause();
} 

static void DisplayPepperoniPizza(Random random, int rows)
{
    Console.Clear();
    Console.WriteLine(new string('*', rows));

    int numOfPepperoni = random.Next(3, 5);
    int pepperonis = 0;

    for (int i = rows - 1; i > 0; i--)
    {
        Console.Write('*');

        for (int j = 0;j < i - 2; j++)
        {
            if (pepperonis < numOfPepperoni && random.Next(i) == 0)
            {
                Console.Write("[]");
                pepperonis++;
            }
            else
            {
                Console.Write('#');
            }
        }

        Console.Write('*');
        Console.WriteLine();
    }
    
    Console.WriteLine('*');
    
    Pause();
}

static void Pause(){
    System.Console.WriteLine(" Press 'Enter' to continue ...");
}