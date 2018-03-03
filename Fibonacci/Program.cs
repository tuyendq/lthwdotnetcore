using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
                Console.WriteLine("Why don't you write the Fibonacci yet? Try it!");
            }

            int number; // Numbers of Fibonacci to display

            // Console.WriteLine("Fibonacci Numbers 1-15:");
            Console.WriteLine("How many Fibonacci numbers do you want to display?");
            do {
              Console.WriteLine("Type in an integer from 1 to 20: ");
              number = Convert.ToInt32(Console.ReadLine());
              if ((number >=1) && (number <=20))
              {
                break;
              }
              else
              {
                Console.WriteLine("Please type in an integer!");
                continue;
              }
            } while (true);

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"{i + 1}: {FibonacciNumber(i)}");
            }
        }

        static int FibonacciNumber(int n)
        {
            int a = 0;
            int b = 1;
            int tmp;

            for (int i = 0; i < n; i++)
            {
                tmp = a;
                a = b;
                b += tmp;
            }

            return a;
        }

    }
}
