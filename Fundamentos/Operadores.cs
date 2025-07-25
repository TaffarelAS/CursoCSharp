using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Operadores
    {
        public static void Executar()
        {
            double a = 20;
            double b = 15.10;
            double c = 180.70;
            int d = 2;

            // operadores relacionais
            Console.WriteLine(a <= b);
            Console.WriteLine(b >= a);
            Console.WriteLine(b != c);
            Console.WriteLine(d == c);

            // operadores lógicos
            // && = E : as duas operações logicas tem que ser verdadeiras
            Console.WriteLine((a == b) && (d!=c));
            // || = OU : apenas uma das operações tem que ser verdadeira para a operação ser true
            Console.WriteLine((d<=a) || (c<=b));
        }
    }
}
