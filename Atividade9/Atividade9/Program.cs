using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, contador1 = 0, contador2 = 0, contador3 = 0, contador4 = 0;
            string j;
            do
            {
                Console.WriteLine("Quantos números você deseja escrever?");
                a = int.Parse(Console.ReadLine());
                for (int i = 0; i < a; i++)
                {
                    b = int.Parse(Console.ReadLine());
                    if (b % 2 == 0)
                    {
                        contador1++;
                    }
                    if (b % 2 != 0)
                    {
                        contador2++;
                    }
                    if (b >= 0)
                    {
                        contador3++;
                    }
                    if (b < 0)
                    {
                        contador4++;
                    }
                }
                Console.WriteLine("Você digitou ao total:");
                Console.WriteLine((contador1) + "Números pares");
                Console.WriteLine((contador2) + "Números ímpares");
                Console.WriteLine((contador3) + "Números positivos");
                Console.WriteLine((contador4) + "Números negativos\n");

                Console.WriteLine("Deseja encerrar o programa?");
                Console.WriteLine("(S para sim e N para não)");
                j = Console.ReadLine();
            }
            while (j == "N");
        }
    }
}