using System;
using System.ComponentModel;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            int n, m;
            int c = 1;
            while (c <= 10)
            {
                do
                {
                    Console.WriteLine("insira um numero de 0 a 10");
                    n = int.Parse(Console.ReadLine());
                    if (n < 0 || n > 10)
                    {
                        Console.WriteLine("o numero deve ser um valor entre 0 a 10");

                    }
                } while (n < 0 || n > 10);
                s += n;
                c++;
            }
            m = s / 10;
            Console.WriteLine("a média é " + m);
        }
    }
        
    }