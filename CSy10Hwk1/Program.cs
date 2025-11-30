using System;

namespace CSy10Hwk1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check divisions");
            string? input = Console.ReadLine();
            int n;
            while (!int.TryParse(input, out n))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                input = Console.ReadLine();
            }

            Console.WriteLine($"The number of divisions possible with that number till 5 was: {Divs(n)}");
        }

        static float Divs(int n)
        {
            float a = n;
            float count = 0;
            while (a > 5)
            {
                a = a / 2;
                count++;
            }
            return count;
        }
    }
}