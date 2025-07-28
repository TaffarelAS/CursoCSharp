using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosFundamentos
{
    internal class Exercicio7
    {
        public static void Executar() {
            Console.WriteLine("Insira um numero de 1 a 7 que corresponda ao dia da semana (Ex. 1 = Domingo, 2 = Segunda...)");
            int num = int.Parse(Console.ReadLine());

            switch (num) {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                    case 2:
                    Console.WriteLine("Segunda");
                    break;
                    case 3:
                    Console.WriteLine("Terça");
                    break;
                    case 4:
                    Console.WriteLine("Quarta");
                    break;
                    case 5:
                    Console.WriteLine("Quinta");
                    break;
                    case 6:
                    Console.WriteLine("Sexta");
                    break;
                    case 7:
                    Console.WriteLine("Sabado");
                    break;
                    default:
                    Console.WriteLine("Numero Invalido");
                    break;
            }
        }
    }
}
