using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;

            Console.WriteLine("Digite o valor mensal de maio referente a venda de carros:");
            valor = double.Parse(Console.ReadLine());

            valor *= 0.05;

            Console.WriteLine("Sua comissão é de: " + valor + " reais");

        }
    }
}