using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Ref. (5 pontos)
10 - Escreva um programa que leia um número e verifique se ele é par ou ímpar.
Nome:pedro tralia pestana
*/
namespace Aula_04
{
    public class Atividade10
    {
        public static void Executar()
        {
            Console.Write("digite um numero: ");
            double numero = double.Parse(Console.ReadLine()!);

            if (numero %2 == 0)
            {
                Console.WriteLine("O numero é par");
            }
            else
            {
                Console.WriteLine("O numero é inpar");
            }
        }
    }
}