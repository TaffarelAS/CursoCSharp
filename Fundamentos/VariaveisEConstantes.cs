using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            // O var interpreta a variavel que você criou de acordo com o tipo dele
            var fruta = "BANANA";
            var tanto = 155;

            Console.WriteLine($"EU ADORO {fruta} EU TENHO {tanto} {fruta}S");

            /*
            string nome = "Bruno";
            int idade = 22;
            double altura = 1.67;
            bool temGato = true;

            Console.WriteLine($"Olá meu nome é {nome}, tenho {idade} de idade, tenho {altura} de altura, tenho gato? {temGato}");

            
            //variavel
            double raio = 4.5;
            //constante
            const double pi = 3.14;

            double area = pi * raio * raio;

            Console.WriteLine("A area total é "+area);
            */
        }
    }
}
