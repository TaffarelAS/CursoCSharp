using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumeros
    {
        public static void Executar()
        {
            //arredondar numeros
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));

            //Transformar em valor monetario
            Console.WriteLine(valor.ToString("C"));

            //Formatando o numero do jeito que você quer.
            Console.WriteLine(valor.ToString("#.##"));

            //Porcentagem
            Console.WriteLine(valor.ToString("P1"));

            
        }
    }
}
