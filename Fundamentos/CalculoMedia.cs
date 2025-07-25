using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class CalculoMedia
    {
        public static void Executar ()
        {
            Console.WriteLine("Insira dois valores para o calcula da nota do aluno!");
            Console.WriteLine("Insira a primeira Nota:");
            var n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a segunda nota:");
            var n2 = double.Parse(Console.ReadLine());

            var soma = (n1 * 3.5 + n2 * 7.5) / 11;
            Console.WriteLine($"A média das duas notas é{soma.ToString("F1")}");
        }
    }
}
