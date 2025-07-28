using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosFundamentos
{
    internal class Exercicio5
    {
        public static void Executar()
        {
            
            int num;
            do
            {
                Console.WriteLine("Seja bem vindo, Pressione 1 para dizer Olá, Pressione 2 para mostrar a data e hora, pressione 3 para sair!");
                num = int.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        Console.WriteLine("Olá");
                        break;
                    case 2:
                        Console.WriteLine(DateTime.Now.ToString());
                        break;
                    case 3:
                        Console.WriteLine("Saindo do programa!");
                        break;
                    default:
                        Console.WriteLine("Valor invalido");
                        break;
                }
            } while (num != 3);
        }
    }
}

