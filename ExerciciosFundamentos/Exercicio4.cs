using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosFundamentos
{
    internal class Exercicio4
    {
        public static void Executar() {
            Console.WriteLine("Insira 5 valores a seguir:");
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var n3 = int.Parse(Console.ReadLine());
            var n4 = int.Parse(Console.ReadLine());
            var n5 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3 && n1 > n4 && n1 > n5) {
                Console.WriteLine($"O maior numero é {n1}");
            } 
            else if (n2 > n1 && n2 > n3 && n2 > n4 && n2 > n5) {
                Console.WriteLine($"O maior numero é {n2}");
            }
            else if (n3 > n1 && n3 > n2 && n3 > n4 && n3 > n5)
            {
                Console.WriteLine($"O maior numero é {n3}");
            }
            else if (n4 > n1 && n4 > n2 && n4 > n3 && n4 > n5)
            {
                Console.WriteLine($"O maior numero é {n4}");
            }
            else if (n5 > n1 && n5 > n3 && n5 > n4 && n5 > n2)
            {
                Console.WriteLine($"O maior numero é {n5}");
            } 
        }
    }
}
