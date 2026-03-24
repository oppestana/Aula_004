using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
/*Ref. (10 pontos)
8 - Crie um programa que faça 5 perguntas para uma pessoa sobre um crime. 
As perguntas são:
"Telefonou para a vítima?"
"Esteve no local do crime?"
"Mora perto da vítima?"
"Devia para a vítima?"
"Já trabalhou com a vítima?"
O programa deve, no final, emitir uma classificação sobre a participação da pessoa no 
crime. Se a pessoa responder positivamente a 2 questões, ela deve ser 
classificada/exibida como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como "Assassino". 
Caso contrário, ela será classificada como "Inocente".
Aluno: pedro tralia pestana
*/
namespace Aula_04
{
    public class Atividade8
    {
        public static void Executar()
        {
            string pergunta1;
            string pergunta2;
            string pergunta3;
            string pergunta4;
            string pergunta5;
            int tdp = 0;

            Console.WriteLine("Voce telefonou para a vitima? ");
            pergunta1 = Console.ReadLine()!;
            if (pergunta1 == "sim")
            {
                tdp ++;
            }
            
             Console.WriteLine("Voce esteve no local do crime? ");
            pergunta2 = Console.ReadLine()!;
            if (pergunta2 == "sim")
            {
                tdp ++;
            }

             Console.WriteLine("Voce mora perto da vitima? ");
            pergunta3 = Console.ReadLine()!;
            if (pergunta3 == "sim"){
                tdp ++;
            }
            
             Console.WriteLine("Voce devia para vitima? ");
            pergunta4 = Console.ReadLine()!;
            if (pergunta4 == "sim")
            {
                tdp ++;
            }

             Console.WriteLine("Voce já trabalhou com a vitima? ");
            pergunta5 = Console.ReadLine()!;
            if (pergunta5 == "sim")
            {
                tdp ++;
            }
            if (tdp == 2)
            {
                Console.WriteLine("voce é suspeito");
            }
            else if (tdp >= 3 && tdp <= 4)
            {
                Console.WriteLine("voce é Cumplise");
            }
            else if (tdp == 5)
            {
                Console.WriteLine("voce é assasino");
            }
            else
            {
                Console.WriteLine("voce é inocente");
            }
        }
    }
}