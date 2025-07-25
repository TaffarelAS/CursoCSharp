using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class EstruturaRepeticao
    {
        public static void Executar()
        {
            /*
            int cont = 1;

            while (cont <= 10)
            {
                Console.WriteLine(cont);
                cont++;
            }
            */

            /*
            for (int cont = 0; cont <=10 ; cont++)
            {
                Console.WriteLine(cont);
            }
            */

            /*
            string entrada = "";
            while(entrada.ToLower()  != "sair")
            {
                Console.WriteLine("Digite uma palavra ou sair para encerrar");
                entrada = Console.ReadLine();
                Console.WriteLine($"Você digitou a palavra {entrada}");
            }
            Console.WriteLine("Programa encerrado");
            */

            int soma = 0;
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine("Digite um número: ");
                int n1 = int.Parse(Console.ReadLine());
                soma += n1;
            }
            Console.WriteLine($"A soma total é de {soma}");
        }
    }
}
