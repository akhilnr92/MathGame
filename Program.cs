
Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();
var date = DateTime.UtcNow;

Menu(name, date);

void Menu(string name, DateTime date)
{
    Console.WriteLine("---------------------------------------");
    Console.WriteLine($@"{date} 
 Hi {name}, select a game to play: 
 A - Addition
 B - Subtraction
 C - Multiplication
 D - Division
 Q - Quit");

    Console.WriteLine("---------------------------------------");

    string gameSelected = Console.ReadLine().Trim().ToUpper();

    switch (gameSelected)
    {
        case "A":

            Console.WriteLine("Addition");
            Add();
            break;

        case "B":

            Console.WriteLine("Subtraction");
            Sub();
            break;

        case "C":

            Console.WriteLine("Multiplication");
            Multiply();
            break;

        case "D":

            Console.WriteLine("Division");
            Divide();
            break;

        case "Q":

            Console.WriteLine("Bye");
            Environment.Exit(1);
            break;

        default:

            Console.WriteLine("Invalid");
            break;
    }
}

void Add()
{
    var random = new Random();

    int firstNumber = random.Next(0,9);
    int secondNumber = random.Next(0,9);
    Console.WriteLine($"{firstNumber} + {secondNumber}");

    var answer = Console.ReadLine();

    if (int.Parse(answer) == firstNumber + secondNumber)
    {
        Console.WriteLine("Your answer is correct !!");
    }
    else
    {
        Console.WriteLine("Your answer is wrong !");
    }


}

void Sub()
{
    var random = new Random();

    int firstNumber = random.Next(0,9);
    int secondNumber = random.Next(0,9);
    Console.WriteLine($"{firstNumber} - {secondNumber}");

    var answer = Console.ReadLine();

    if (int.Parse(answer) == firstNumber - secondNumber)
    {
        Console.WriteLine("Your answer is correct !!");
    }
    else
    {
        Console.WriteLine("Your answer is wrong !");
    }

}
void Multiply()
{
    var random = new Random();

    int firstNumber = random.Next(0,9);
    int secondNumber = random.Next(0,9);
    Console.WriteLine($"{firstNumber} * {secondNumber}");

    var answer = Console.ReadLine();

    if (int.Parse(answer) == firstNumber * secondNumber)
    {
        Console.WriteLine("Your answer is correct !!");
    }
    else
    {
        Console.WriteLine("Your answer is wrong !");
    }

}
void Divide()
{

}
Console.ReadLine();