using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_04
{
    public class Exercicio1
    {
        public static void Executar()
        {
            double nota; 
            double frequencia;

            Console.WriteLine("Digite a nota do aluno: ");
            nota = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Digite a frequencia do aluno: %");
            frequencia = double.Parse(Console.ReadLine()!);

            if (nota >= 7)
            {
                if (frequencia >= 75)
                {
                    Console.WriteLine("Aluno aprovado!");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado por falta!");
                }
                
            }
            else
            {
                Console.WriteLine("Aluno reprovado por nota");
            }

        }
    }
}