using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class LendoDados
    {
        public static void Executar()
        {
            //Perguntado o nome do usuario
            Console.WriteLine("Qual seu nome?");
            var nome = Console.ReadLine();
            //Perguntando idade do usuario
            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());
            //Perguntando altura do usuario
            Console.WriteLine("Digite sua altura");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine($"{nome} - {idade} - {altura}");
        }
    }
}
