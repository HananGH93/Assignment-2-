using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                float result;
                Console.Write("Enter first number:");
                float num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number:");
                float num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter symbol(/,+,-,*):");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine("Addition:" + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine("Subtraction:" + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine("Multiplication:" + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine("Division:" + result);
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
                Console.ReadLine();
                Console.Write("Do you want to continue(y/n):");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");
        }
    }

}