using System;
using System.Globalization;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            int i = 0;
            while (i == 0)
            {
                Console.WriteLine("Digite o valor A e o valor B: ");
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());

                a %= b;

                if (a != 0)
                {
                    Console.WriteLine("O resto da divisao é: " + a);
                    i = 1;
                }
                else
                {
                    Console.WriteLine("A divisão em questao resulta em 0, por favor escolha outros numeros");
                }
            }

        }
    }
}