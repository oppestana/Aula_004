using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
/*Ref. (10 pontos)
6 - Um programa deve ler três ângulos e verificar qual é o tipo de triângulo formado. 
Primeiro, é necessário conferir se a soma dos três ângulos é igual a 180°, 
pois só assim eles formam um triângulo. Depois, se um dos ângulos for igual a 90°, 
o triângulo é retângulo. Se um dos ângulos for maior que 90°, ele é obtusângulo. 
Caso contrário, se os três forem menores que 90°, o triângulo é acutângulo.
Nome: pedro tralia pestana
*/
namespace Aula_04
{
    public class Atividade6
    {
        public static void Executar()
        {
            Console.Write("digite o primeiro angulo: ");
            double ang1 = double.Parse(Console.ReadLine()!);

            Console.Write("digite o segundo angulo: ");
            double ang2 = double.Parse(Console.ReadLine()!);

            Console.Write("digite o terceiro angulo: ");
            double ang3 = double.Parse(Console.ReadLine()!);

            double Sa = ang1 + ang2 + ang3;

            if (Sa != 180)
            {
                Console.WriteLine($"Não é um triangulo");
            }
            else if (ang1 == 90 || ang2 == 90 || ang3 == 90)
            {
                Console.WriteLine($"Essa forma é um triangulo retangulo");
            }
            else if (ang1 > 90 || ang2 > 90 || ang3 > 90 )
            {
                Console.WriteLine($"Essa forma é um triangulo obtusangulo");
            }
            else if (ang1 < 90 || ang2 < 90 || ang3 < 90)
            {
                Console.WriteLine($"Essa forma é um triangulo acutangulo");
            }
        }
    }
}