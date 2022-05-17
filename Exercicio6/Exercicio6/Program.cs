using System;
using System.Globalization;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura;

            Console.WriteLine("Digite sua altura:");
            altura = double.Parse(Console.ReadLine());

            altura = (72.7 * altura) - 58;

            Console.WriteLine("Seu peso ideal é de: " + altura.ToString("F1") + " quilos");

        }
    }
}