using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b = 1;
            Console.WriteLine("Digite um número.");
            a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                b = b * i;
            }
            Console.WriteLine(b);
        }
    }
}