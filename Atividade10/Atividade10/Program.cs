using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string c, d;
            int n, e;
            do
            {
                Console.WriteLine("Digite o código do Operário");
                c = Console.ReadLine();
                Console.WriteLine("Nos informe quantas horas ele trabalhou na semana");
                n = int.Parse(Console.ReadLine());
                if (n <= 50)
                {
                    Console.WriteLine("\nO operário " + c + " que trabalhou " + n + "horas irá ganhar no total:");
                    Console.WriteLine("R$" + (n * 10));
                }
                if (n > 50)
                {
                    e = (n - 50);
                    Console.WriteLine("\nO operário " + c + " que trabalhou " + n + " horas irá ganhar:");
                    Console.WriteLine("R$" + (n * 10 + e * 20) + " de salário total e R$" + (e * 20) + " de salário excedente");
                }
                Console.WriteLine("Deseja encerrar o programa?");
                Console.WriteLine("(S para Sim e N para Não)");
                d = Console.ReadLine();
            }
            while (d == "N");
        }
    }
}