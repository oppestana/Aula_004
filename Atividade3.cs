using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;


namespace Aula_04
{
    public static class Atividade3
    {
        public static void Executar()
        {
            int numero1;
            int numero2;
            int numero3;

            Console.Write("Digite o primeiro número: ");
            numero1 = int.Parse(Console.ReadLine()!);
            
            Console.Write("Digite o segundo número: ");
            numero2 = int.Parse(Console.ReadLine()!);
            
            Console.Write("Digite o terceiro número: ");
            numero3 = int.Parse(Console.ReadLine()!);

            double maiorN = 0;
            double medioN = 0;
            double menorN = 0;
        //cmc
            if (numero1 > numero2 || numero1 > numero3)
            {
                 if (numero1 > numero2 && numero1 > numero3)
                {
                    maiorN = numero1;
                }
                else
                {
                    medioN = numero1;
                }
            
            }
            else
            {
                menorN = numero1;
            }
        //fim

         //cmc
            if (numero2 > numero1 || numero2 > numero3)
            {
                 if (numero2 > numero1 && numero2 > numero3)
                {
                    maiorN = numero2;
                }
                else
                {
                    medioN = numero2;
                }
            
            }
            else
            {
                menorN = numero2;
            }
        //fim
            
             //cmc
            if (numero3 > numero1 || numero3 > numero2)
            {
                 if (numero3 > numero1 && numero3 > numero2)
                {
                    maiorN = numero3;
                }
                else
                {
                    medioN = numero3;
                }

            
            }
            else
            {
                menorN = numero3;
            }
        //fim
            Console.WriteLine($"{menorN}, {medioN}, {maiorN}");

        }
    }
}