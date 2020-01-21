using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Examination of water status");
            Console.WriteLine("temperature: ");

            Double a = Convert.ToDouble(Console.ReadLine());

            if (a > 0)
            {
                if (a >= 100) Console.WriteLine("Steam");
                else Console.WriteLine("Water");
            }
            else Console.WriteLine("Ice");

            Console.ReadLine();
        }
    }
}
