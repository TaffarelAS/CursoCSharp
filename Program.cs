using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.ExerciciosFundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Numeros - Fundamentos", FormatandoNumeros.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Exercicio Calculo de Média - Fundamentos", CalculoMedia.Executar},
                {"Operadores Racionais e Lógicos - Fundamentos", Operadores.Executar},
                {"Operadores de Atruibuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Estrutura de Condição - Fundamentos", EstruturaCondicao.Executar},
                {"Estrutura Switch - Fundamentos", EstruturaSwitch.Executar},
                {"Estrutura de Repetição - Fundamentos", EstruturaRepeticao.Executar},


                // EXERCICIOS C#
                {"Exercicio 1 - Exercicios Fundamentos", Exercicio1.Executar},
                {"Exercicio 2 - Exercicios Fundamentos", Exercicio2.Executar},
                {"Exercicio 3 - Exercicios Fundamentos", Exercicio3.Executar},
                {"Exercicio 4 - Exercicios Fundamentos", Exercicio4.Executar},
                {"Exercicio 5 - Exercicios Fundamentos", Exercicio5.Executar},
                {"Exercicio 6 - Exercicios Fundamentos", Exercicio6.Executar},
                {"Exercicio 7 - Exercicios Fundamentos", Exercicio7.Executar},
                {"Exercicio 8 - Exercicios Fundamentos", Exercicio8.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}