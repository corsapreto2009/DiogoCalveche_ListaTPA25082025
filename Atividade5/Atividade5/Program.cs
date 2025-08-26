using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b = 0;
            Console.WriteLine("Digite 15 números.");

            for (int i = 0; i < 15; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a > b) b = a;
            }
            Console.WriteLine(b);
        }
    }
}