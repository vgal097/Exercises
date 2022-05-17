using System;
using System.Globalization;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nota = new double[4];

            int i = 0;
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite a nota:");
                nota[i] = double.Parse(Console.ReadLine());
            }

            double media = (nota[0] + nota[1] + nota[2] + nota[3]) / 4;

            if (media > 7)
            {
                Console.WriteLine("Sua media foi nota " + media + ", APROVADO");
            }
            else
            {
                Console.WriteLine("Sua media foi nota " + media + ", REPROVADO");
            }

        }
    }
}