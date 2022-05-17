using System;
using System.Globalization;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp;

            Console.WriteLine("Digite o valor da temperatura em graus Fahrenheit: ");
            temp = double.Parse(Console.ReadLine());

            temp = ((temp - 32) * 5) / 9;

            Console.WriteLine("A temperatura é de " + temp.ToString("F2") + " C");

        }
    }
}