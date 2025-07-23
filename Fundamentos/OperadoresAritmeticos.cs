using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAritmeticos
    {
        public static void Executar ()
        {
            Console.WriteLine("Calculadora de soma :D");
            Console.WriteLine("Insira um valor: ");
            var valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira outro valor: ");
            var valor2 = double.Parse(Console.ReadLine());

            var soma = valor1 + valor2;

            Console.WriteLine($"A soma dos dois numero é {soma.ToString("F")}");
        }
    }
}
