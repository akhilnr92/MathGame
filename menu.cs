
namespace MathGame
{
    public class Menu
    {
        Engine engine = new Engine();

        
        internal void ShowMenu(string name, DateTime date)
        {
            bool isGameOn = true;

            do
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($@"{date} 
 Hi {name}, select a game to play: 
 A - Addition
 B - Subtraction
 C - Multiplication
 D - Division
 H - History
 Q - Quit");

                Console.WriteLine("---------------------------------------");

                string gameSelected = Console.ReadLine().Trim().ToUpper();

                switch (gameSelected)
                {
                    case "A":

                        Console.WriteLine("Addition");
                        engine.Add();
                        break;

                    case "B":

                        Console.WriteLine("Subtraction");
                        engine.Sub();
                        break;

                    case "C":

                        Console.WriteLine("Multiplication");
                        engine.Multiply();
                        break;

                    case "D":

                        Console.WriteLine("Division");
                        engine.Divide();
                        break;

                    case "H":

                        Console.WriteLine("History");
                        engine.ShowHistory();
                        break;    

                    case "Q":

                        Console.WriteLine("Bye");
                        isGameOn = false;
                        Environment.Exit(1);
                        break;

                    default:

                        Console.WriteLine("Invalid");
                        break;
                }
            } while (isGameOn);
        }
    }
}