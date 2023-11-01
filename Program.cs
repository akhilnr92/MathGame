using MathGame;

Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();
var date = DateTime.UtcNow;

var menu = new Menu();

menu.ShowMenu(name, date);

Console.ReadLine();