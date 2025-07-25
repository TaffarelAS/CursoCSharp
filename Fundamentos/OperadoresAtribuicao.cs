using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAtribuicao
    {
        public static void Executar ()
        {
            var num = 3;

            num = 30;
            //subtituindo o 3 por 30
            Console.WriteLine(num);
            //atribuição aditiva
            num += 10;
            Console.WriteLine(num);
            //atribuição subtrativa
            num -= 50;
            Console.WriteLine(num);
            //Incremento e Decremento
            var a = 1;
            var b = 1;

            a++;
            b--;
            Console.WriteLine($"{a} - {b}");
        }
    }
}
