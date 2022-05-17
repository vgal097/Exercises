using System;
using System.Globalization;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeMin, idadeMax;

            Console.WriteLine("Digite a idade do aluno mais novo e a do mais velho: ");
            idadeMin = int.Parse(Console.ReadLine());
            idadeMax = int.Parse(Console.ReadLine());

            idadeMin = (idadeMin + idadeMax) / 2;

            Console.WriteLine("A idade media dos alunos é: " + idadeMin + " anos");

        }
    }
}
