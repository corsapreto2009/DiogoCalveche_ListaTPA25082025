using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Digite um número e eu mostrarei sua tabuada.");
            a = int.Parse(Console.ReadLine());
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(a + " * " + i + " = " + a * i);
            }
        }
    }
}