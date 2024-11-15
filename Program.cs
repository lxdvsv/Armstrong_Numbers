namespace Armstrong_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствую тебя на пути поиска чисел Армстронга! Однажды ты превзойдешь мастера.");

            bool playAgain;
            do
            {
                int N = GetUserInput();
                Console.WriteLine($"Числа Армстронга от 1 до {N}:");

                for (int number = 1; number <= N; number++)
                {
                    if (IsArmstrongNumber(number))
                    {
                        Console.WriteLine(number);
                    }
                }

                playAgain = AskToPlayAgain();
            } while (playAgain);

            Console.WriteLine("Благодарю за испытание, воин. Однажды я стану сильнее. До новых сражений!");

        }

        static int GetUserInput()
        {
            int N;
            while (true)
            {
                Console.Write("Введите значение N (положительное целое число): ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out N) && N > 0)
                {
                    break;
                }
                Console.WriteLine("Ошибка: Введите положительное целое число.");
            }
            return N;
        }

        static bool IsArmstrongNumber(int number)
        {
            int sum = 0;
            int temp = number;
            int digits = CountDigits(number);

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, digits);
                temp /= 10;
            }

            return sum == number;
        }

        static int CountDigits(int number)
        {
            int count = 0;
            while (number > 0)
            {
                count++;
                number /= 10;
            }
            return count;
        }

        static bool AskToPlayAgain()
        {
            Console.Write("Желаешь испытать свою волю снова? (да/нет): ");
            string response = Console.ReadLine().ToLower();
            return response == "да" || response == "нет";
        }
    }
}