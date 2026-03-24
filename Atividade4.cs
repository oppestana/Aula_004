using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
// /*Ref (15 pontos)
// 4 – Ler valor de nota de N1 e N2, calcular a média e escrever a nota correspondente, 
// tal que 0 é a menor nota e 10 a maior, e imprimir o conceito equivalente 
// (A, B, C, D ou E), conforme a seguinte tabela:
// A  -   nota >= 8,5  e nota <= 10
// B  -   nota >= 7    e nota < 8,5
// C  -   nota >= 5    e nota < 7
// D  -   nota >= 3    e nota < 5
// E  -   nota < 3
// Nome:
// */pedro tralia pestana
namespace Aula_04
{
    public class Atividade4
    {
        public static void Executar()
        {
            double N1;
            double N2;

            Console.Write("digite a primeira nota: ");
            N1 = double.Parse(Console.ReadLine()!);

             Console.Write("digite a segunda nota: ");
            N2 = double.Parse(Console.ReadLine()!);

            double media = (N1 + N2) / 2;
            Console.WriteLine($"A nota media é: {media}");

    
            if (media >= 8.5 && media <= 10)
            {
                Console.WriteLine($"A media é {media} logo a nota do aluno é: A");
            }
            else
            {
                if (media >= 7 && media <= 8.5)
                {
                    Console.WriteLine($"A media é {media} logo a nota do aluno é: B");
                }
                else
                {
                    if (media >= 5 && media <= 7)
                {
                    Console.WriteLine($"A media é {media} logo a nota do aluno é: C");
                }
                    else
                    {
                        if (media >=3 && media <= 5)
                        {
                            Console.WriteLine($"A media é {media} logo a nota do aluno é: D");
                        }
                        else
                        {
                            if (media <= 3)
                            {
                                Console.WriteLine($"A media é {media} logo a nota do aluno é: E");
                            }
                        }
                    }
                }

            }
        }
    }
}