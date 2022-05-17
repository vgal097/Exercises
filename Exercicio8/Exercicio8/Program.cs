using System;
using System.Globalization;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.WriteLine("Digite o valor A e o valor B: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());

            a -= b;

            if (a > 0)
            {
                Console.WriteLine("o valor total é: " + a + ", sendo um numero POSITIVO");
            }
            else if (a == 0)
            {
                Console.WriteLine("o valor total é: " + a + ", sendo um numero NEUTRO");
            }
            else
            {
                Console.WriteLine("o valor total é: " + a + ", sendo um numero NEGATIVO");
            }
        }
    }
}