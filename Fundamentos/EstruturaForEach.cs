using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class EstruraForEach
    {
        public static void Executar()
        {
            var palavra = "Olá";

            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }
            //percorrendo um array

            var alunos = new string[] { "ana", "bia", "joão" };
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
            Console.WriteLine(alunos[0]);
        }
    }
}