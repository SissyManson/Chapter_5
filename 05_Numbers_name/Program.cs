using System;

namespace _05_Numbers_name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int number = Int32.Parse(Console.ReadLine());

            switch (number)
            {
                case 0: Console.WriteLine("Nula"); break;
                case 1: Console.WriteLine("Edno"); break;
                case 2: Console.WriteLine("Dve"); break;
                case 3: Console.WriteLine("Tri"); break;
                case 4: Console.WriteLine("Chetiri"); break;
                case 5: Console.WriteLine("Pet"); break;
                case 6: Console.WriteLine("Shest"); break;
                case 7: Console.WriteLine("Sedem"); break;
                case 8: Console.WriteLine("Osem"); break;
                case 9: Console.WriteLine("Devet"); break;
                default: Console.WriteLine("Wrong input"); break;
            }
        }
    }
}
