using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_04
{
//     *Ref (5 pontos)
// 1 - Faça um programa que calcule e apresente o valor do volume de uma lata, 
// sabendo que PI é um valor constante de 3.14159, o programa deve pedir os valores 
// de RAIO e ALTURA, utilize a fórmula VOLUME = PI * RAIO² * ALTURA.
    // Nome: Pedro Tralia Pestana
    public class Atividade1
    {
        public static void Executar()
        {
            double PI = 3.14159;
            double RAIO;
            double ALTURA;
            double VOLUME;

            Console.Write("Digite o raio da lata: ");
            RAIO = double.Parse(Console.ReadLine()!);

            Console.Write("digite a altura da lata: ");
            ALTURA = double.Parse(Console.ReadLine()!);

            VOLUME = PI * (RAIO * RAIO) * ALTURA;
            Console.WriteLine($"O volume da lata é {VOLUME} ");


        }
    }
}