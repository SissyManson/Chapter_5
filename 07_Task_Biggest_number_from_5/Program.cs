using System;

namespace _07_Task_Biggest_number_from_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = Int32.Parse(Console.ReadLine());
            Console.Write("Enter fourth number: ");
            int d = Int32.Parse(Console.ReadLine());
            Console.Write("Enter fifth number: ");
            int e = Int32.Parse(Console.ReadLine());

            if (a < b) a = b;
            if (a < c) a = c;
            if (a < d) a = d;
            if (a < e) a = e;

            Console.WriteLine("{0} is the biggest number.", a);
        }
    }
}
