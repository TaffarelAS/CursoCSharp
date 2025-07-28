using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosFundamentos
{
    internal class Exercicio3
    {
        public static void Executar()
        {
            Console.WriteLine("Insira um ano a seguir e o computador ira informa-lo se este ano é bissexto ou não:");
            var ano = int.Parse(Console.ReadLine());

            if (ano % 4 == 0 && ano % 100 != 0)
            {
                Console.WriteLine("Este ano é bissexto");
            }
            else if (ano % 400 == 0)
            {
                Console.WriteLine("Este ano é bissexto");
            }
            else
            {
                Console.WriteLine("Este ano não é bissexto");
            };

        }
    }
}
