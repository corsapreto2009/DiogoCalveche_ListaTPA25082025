using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0;
            Console.WriteLine("Digite um número.");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número.");
            b = int.Parse(Console.ReadLine());

            for (int i = a; i >= b; i--)
            {

                if (i % 2 == 1)
                {
                    c++;
                }
            }
            Console.WriteLine("{0}", c);
        }
    }
}