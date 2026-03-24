using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Ref. (15 pontos)
7 - Para doar sangue é necessário ter entre 18 e 67 anos e possuir mais de 60 kg. 
Faça um aplicativo que pergunte a idade de uma pessoa e seu peso e diga se ela pode 
doar sangue ou não; caso não possa, diga o(s) motivo(s).
Nome:pedro tralia pestana
*/
namespace Aula_04
{
    public class Atividade7
    {
        public static void Executar()
        {
            Console.Write("digite a sua idade: ");
            double idade = double.Parse(Console.ReadLine()!);

            Console.Write("Digite o seu peso: ");
            double peso = double.Parse(Console.ReadLine()!);

            if (idade > 18 && idade < 67 && peso > 60 )
            {
                Console.WriteLine("Sim voce pode doar sangue");
            }
            else if (idade > 18 && idade <67)
            {
                Console.WriteLine("Voce nao pode doar sangue, pois seu peso esta acima de 60kg");
            }
            else if (peso > 60)
            {
                Console.WriteLine("Voce nao pode doar sangue, pois sua idade nao é adequada");
            }
            else
            {
                Console.WriteLine("Voce nao pode doar sangue, pois voce nao atende nenhum requisito");
            }
        }
    }
}