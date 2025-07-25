using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

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
            });

            central.SelecionarEExecutar();
        }
    }
}