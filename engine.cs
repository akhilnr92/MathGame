using Models;

namespace MathGame
{
    internal class Engine
    {
        int score = 0;
        public static List<History> histories = new List<History>();
        internal void Add()
        {

            var random = new Random();

            int firstNumber = random.Next(0, 9);
            int secondNumber = random.Next(0, 9);
            Console.WriteLine($"{firstNumber} + {secondNumber}");

            var answer = Console.ReadLine();

            answer = ValidateAnswer(answer);

            if (int.Parse(answer) == firstNumber + secondNumber)
            {
                Console.WriteLine("Your answer is correct !!");
                score++;
                Console.WriteLine($"Your score is:{score}");
                AddHistory(score, GameType.Addition);

            }
            else
            {
                Console.WriteLine("Your answer is wrong !");
                Console.WriteLine($"Your score is:{score}");
                AddHistory(score, GameType.Addition);
            }


        }

        internal void Sub()
        {

            var random = new Random();

            int firstNumber = random.Next(0, 9);
            int secondNumber = random.Next(0, 9);
            Console.WriteLine($"{firstNumber} - {secondNumber}");

            var answer = Console.ReadLine();

            if (int.Parse(answer) == firstNumber - secondNumber)
            {
                Console.WriteLine("Your answer is correct !!");
                score++;
                Console.WriteLine($"Your score is:{score}");
                AddHistory(score, GameType.Subtraction);

            }
            else
            {
                Console.WriteLine("Your answer is wrong !");
                Console.WriteLine($"Your score is:{score}");
                AddHistory(score, GameType.Subtraction);
            }

        }
        internal void Multiply()
        {

            var random = new Random();

            int firstNumber = random.Next(0, 9);
            int secondNumber = random.Next(0, 9);
            Console.WriteLine($"{firstNumber} * {secondNumber}");

            var answer = Console.ReadLine();

            if (int.Parse(answer) == firstNumber * secondNumber)
            {
                Console.WriteLine("Your answer is correct !!");
                score++;
                Console.WriteLine($"Your score is:{score}");
                AddHistory(score, GameType.Multiplication);
            }
            else
            {
                Console.WriteLine("Your answer is wrong !");
                Console.WriteLine($"Your score is:{score}");
                AddHistory(score, GameType.Multiplication);
            }

        }
        internal void Divide()
        {

            int[] divisionNumbers = GetDivisionNumber();
            int firstNumber = divisionNumbers[0];
            int secondNumber = divisionNumbers[1];

            Console.WriteLine($"{firstNumber} / {secondNumber}");

            var answer = Console.ReadLine();

            if (int.Parse(answer) == firstNumber / secondNumber)
            {
                Console.WriteLine("Your answer is correct !!");
                score++;
                Console.WriteLine($"Your score is:{score}");
                AddHistory(score, GameType.Division);
            }
            else
            {
                Console.WriteLine("Your answer is wrong !");
                Console.WriteLine($"Your score is:{score}");
                AddHistory(score, GameType.Division);
            }



        }

        int[] GetDivisionNumber()
        {
            var random = new Random();
            int firstNumber = random.Next(1, 99);
            int secondNumber = random.Next(1, 99);

            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        public static void AddHistory(int score, GameType type)
        {
            histories.Add(new History
            {
                Score = score,
                Type = type,
                Date = DateTime.Now
            });


        }

        public void ShowHistory()
        {
            var gamesToPrint = histories.OrderBy(x=> x.Date);


            foreach (History game in gamesToPrint)
            {
                Console.WriteLine($"{game.Date} {game.Type} Total Score = {game.Score}");
            }
        }

        public static string ValidateAnswer(string answer)
        {
            while (!Int32.TryParse(answer,out _))
            {
                Console.WriteLine("Please enter an Integer");
                answer = Console.ReadLine();
            }
            return answer;
        }
    }
}
