namespace MathGame
{
    internal class Engine
    {
        internal void Add()
        {
            var random = new Random();

            int firstNumber = random.Next(0, 9);
            int secondNumber = random.Next(0, 9);
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
            }
            else
            {
                Console.WriteLine("Your answer is wrong !");
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
            }
            else
            {
                Console.WriteLine("Your answer is wrong !");
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
            }
            else
            {
                Console.WriteLine("Your answer is wrong !");
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
    }
}
