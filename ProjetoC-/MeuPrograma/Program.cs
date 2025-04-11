using System;
using System.Collections.Generic;
using CursoCSharp.EstruturasDeControle;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis E Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação e Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar},
                {"Converções - Fundamentos", Conversoes.Executar},
                {"Operadores Aritimeticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores De Atribuição - Fundamentos", OperadoresDeAtribuicao.Executar},
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternario - Fundamentos", OperadorTernario.Executar},
                // estruturas de controle
                {"Estrutura IF - Estrutura de controle", EstruturaIf.Executar },
                {"Estrutura IF e Else - Estrutura de controle", EstruturaIfElse.Executar },
                {"Estrutura IF e Else praticas - Estrutura de controle", estruturaIfElseIf.Executar },
                {"Estrutura Switch - Estrutura de controle", EstruturaSwitch.Executar },
                {"Estrutura While - Estrutura de controle", EstruturaWhile.Executar },
                {"Estrutura do While - Estrutura de controle", EstruturaDoWhile.Executar },
                {"Estrutura For - Estrutura de controle", EstruturaFor.Executar },
            });
        central.SelecionarEExecutar();
        }
    }
}