

using System;

namespace LogicalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> primeNumbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number (or -1 to finish): ");
                if (int.TryParse(Console.ReadLine(), out int number) && number >= -1)
                {
                    if (number == -1) break;

                    if (IsPrime(number))
                    {
                        primeNumbers.Add(number);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer or -1 to exit.");
                }
            }

            Console.WriteLine("Prime numbers entered:");
            primeNumbers.ForEach(Console.WriteLine);
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
