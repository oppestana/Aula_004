using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_04
{
    //     Ref (5 pontos)
    // 2 – Faça um programa que verifique se uma letra digitada é vogal ou consoante
    // */ pedro tralia pestana
    public class Atividade2
    {
        public static void Executar()
        {
            string letra;

            Console.WriteLine("Digie uma letra para ser verificada: ");
            letra = Console.ReadLine()!.ToLower();

            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
            {
                Console.WriteLine($"A letra '{letra}' e uma vogal");
            }
            else
            {
                Console.WriteLine($"A letra '{letra}' e uma consoante");
            }
        }
    }
}