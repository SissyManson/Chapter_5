using System;

namespace _01_Task_Biggest_number_of_2_with_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Changes the places of the two numbers if the first one is bigger.\n");
            Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());

            if (a > b)
            {
                int c = a;
                a = b;
                b = c;
            }

            Console.WriteLine("First number - {0}, Second number - {1}.", a, b);
        }
    }
}
