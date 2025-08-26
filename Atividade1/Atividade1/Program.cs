using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, c;

            c = 11;

            n = 250;

            while (n > c)
            {
                if (c % 2 == 0)
                {
                    Console.WriteLine("{0}", c);
                }
                c++;
            }
            Console.ReadKey();
        }
    }
}