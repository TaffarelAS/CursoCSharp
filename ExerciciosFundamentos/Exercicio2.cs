using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosFundamentos
{
    internal class Exercicio2
    {
        public static void Executar()
        {
            Console.WriteLine("CALCULADORA -- qual operador você quer usar?");
            Console.WriteLine("1 - SOMA, 2 - SUBTRAÇÃO, 3 - MULTIPLICAÇÃO, 4 - DIVISÃO:");
            var operador = int.Parse(Console.ReadLine());

            switch (operador)
            {
                case 1:
                    Console.WriteLine("Insira o primeiro valor");
                    var n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o segundo valor");
                    var n2 = int.Parse(Console.ReadLine());
                    var soma = n1 + n2;
                    Console.WriteLine($"O resultado do calculo é: {soma}");
                    break;
                case 2:
                    Console.WriteLine("Insira o primeiro valor");
                    var n3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o segundo valor");
                    var n4 = int.Parse(Console.ReadLine());
                    var sub = n3 - n4;
                    Console.WriteLine($"O resultado do calculo é: {sub}");
                    break;
                case 3:
                    Console.WriteLine("Insira o primeiro valor");
                    var n5 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o segundo valor");
                    var n6 = int.Parse(Console.ReadLine());
                    var multi = n5 * n6;
                    Console.WriteLine($"O resultado do calculo é: {multi}");
                    break;
                case 4:
                    Console.WriteLine("Insira o primeiro valor");
                    var n7 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o segundo valor");
                    var n8 = int.Parse(Console.ReadLine());
                    var div = n7 / n8;
                    Console.WriteLine($"O resultado do calculo é: {div}");
                    break;
                default:
                    Console.WriteLine("Numero Inválido");
                    break;
            }
        }
    }
}
