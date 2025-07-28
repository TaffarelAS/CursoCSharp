using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosFundamentos
{
    internal class Exercicio1
    {
        public static void Executar()
        {

            Console.WriteLine("Insira um valor a seguir, o computador ira informar se é negativo ou positivo.");
            long valor = long.Parse(Console.ReadLine());

            if (valor == 0)
            {
                Console.WriteLine("Igual a Zéro");
            }
            else if (valor >= 1)
            {
                Console.WriteLine("Número Positivo");
            }
            else if (valor <= 1)
            {
                Console.WriteLine("Número Negativo");
            }
            else
            {
                Console.WriteLine("Insira um valor valido.");
            }


        }
    }
}
