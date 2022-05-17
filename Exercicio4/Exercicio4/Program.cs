using System;
using System.Globalization;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp;

            Console.WriteLine("Digite o valor da temperatura em graus celsius: ");
            temp = double.Parse(Console.ReadLine());

            temp = (9 * temp + 160) / 5;

            Console.WriteLine("A temperatura é de " + temp + " F");

        }
    }
}