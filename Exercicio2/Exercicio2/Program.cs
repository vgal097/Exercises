using System;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double euro;

            Console.WriteLine("Digite o valor em euros:");
            euro = double.Parse(Console.ReadLine());

            euro *= 5.34;

            Console.WriteLine("o resultado da conversao é de: " + euro + " reais");

        }
    }
}