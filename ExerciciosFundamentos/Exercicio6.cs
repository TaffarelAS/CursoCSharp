using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosFundamentos
{
    internal class Exercicio6
    {

        public static void Executar()
        {
            Console.WriteLine("Insira um valor entre 50 e 100!");
            int valor = int.Parse(Console.ReadLine());

            if (valor >= 50 && valor <= 100)
            {
                Console.WriteLine($"O numero {valor} está entre 50 e 100!");
            }
            else {
                Console.WriteLine($"O numero {valor} não esta entre 50 e 100!");
            }
        }
    }
}
