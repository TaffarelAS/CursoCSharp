using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosFundamentos
{
    internal class Exercicio8
    {
        public static void Executar() { 
            Random random = new Random();
            int randomNum = random.Next(1, 11);
            for (int i = 0; i < 3; i++) {
                Console.WriteLine("Tente acertar o numero randomico que o computador criou");
                int num = int.Parse(Console.ReadLine());

                if (num == randomNum) {
                    Console.WriteLine($"Você acertou! :D O numero erá {randomNum}");
                    break;
                } else if (i == 3) { 
                    Console.WriteLine($"Vocé fracassou o numero era:{randomNum}");
                }
                else
                {
                    Console.WriteLine("Vocé errou!");
                }
                
            }
        }
    }
}
