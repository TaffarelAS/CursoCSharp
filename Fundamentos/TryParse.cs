using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class TryParse
    {
        public static void Executar()
        {

            /*
            Console.WriteLine("Digite um numero: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine($"Resultado {numero}");

            int n1 = int.Parse(Console.ReadLine()); // int.perse
            Console.WriteLine(n1);
            

            string numero = "123";
            int resultado = int.Parse(numero); // funciona: resultado 123

            string invalido = "abc";
            int erro = int.Parse(invalido); // erro: FormatException
        */
            string numero = "123";
            int resultados;
            bool sucesso = int.TryParse(numero, out resultados);// sucesso = true, resultado = 123
            Console.WriteLine(resultados);

            string invalido = "abc";
            bool falhou = int.TryParse(invalido, out resultados); // falhou = false, resultado = 0
            Console.WriteLine(resultados);





        }
    }
}