using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b = 0;
            Console.WriteLine("");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                b = i % 10;
                if (b == 0)
                {
                    Console.WriteLine("MÚLTIPLO DE 10");
                }
            }
        }
    }
}