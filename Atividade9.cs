using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Ref. (5 pontos)
9 - Escreva um programa que leia um número e verifique se ele é positivo,
negativo ou zero.
Nome: pedro tralia pstana
*/
namespace Aula_04
{
    public class Atividade9

    {
        public static void Executar()
        {
            Console.Write("digite um numero: ");
            double numero = double.Parse(Console.ReadLine()!);
             
             if (numero > 0)
            {
                Console.WriteLine("o numero é positivo");
            }
            else if (numero < 0)
            {
                Console.WriteLine("o numero é negativo");
            }
            else
            {
                Console.WriteLine("o numero é = 0");
            }
        }
    }
}