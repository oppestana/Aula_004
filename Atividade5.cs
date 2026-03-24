using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// /*Ref (15 pontos)
// 5 - As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, 
// e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número 
// de maçãs compradas, calcule e escreva o valor total da compra.
// Nome:
// */pedro tralia pestana

namespace Aula_04
{
    public class Atividade5
    {
        public static void Executar()
        {
            int macas;
            double valor;

            Console.Write("digite o numero de maças: ");
            macas = int.Parse(Console.ReadLine()!);

            if (macas < 12)
            {
                valor = macas * 0.30;
                Console.WriteLine($"O valor da compra é: {valor}");
            }
            else 
            {
                if (macas >= 12)
                {
                    valor = macas * 0.25;
                    Console.WriteLine($"O valor da compra é: {valor}");
                }
            }
            
        }
    }
}