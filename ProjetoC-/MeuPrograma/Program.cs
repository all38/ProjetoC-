using System;
using System.Collections.Generic;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.EstruturasDeControle;

using CursoCSharp.Fundamentos;
using MeuPrograma.ClassesEMetodos;

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
                {"Estrutura For Each - Estrutura de controle", EstruturaForEach.Executar },
                {"Usando Break - Estrutura de controle", UsandoBreak.Executar },
                {"Usando Continue - Estrutura de controle", UsandoContinue.Executar },
                // Classes e métodos
                {"Membros - Classes e métodos", Membros.Executar },
                {"Construtor - Classes e métodos", Construtor.Executar },
                {"Métodos com Retorno - Classes e métodos", MetodoComRetorno.Executar },
                {"Métodos Estaticos - Classes e métodos", MetodosEstaticos.Executar },
                {"Atributos estaticos - Classes e métodos", AtributosEstaticos.Executar },
                {"Desafio Atributo - Classes e métodos", DesafioAtributo.Executar },
                {"Params - Classes e métodos", Params.Executar },
                {"Parametros Nomeados - Classes e métodos", ParametrosNomeados.Executar },
                {"Get Set - Classes e métodos", GetSet.Executar },
                {"Props - Classes e métodos", Props.Executar },
                {"Readonly - Classes e métodos", Readonly.Executar },
                {"Exemplo Enum - Classes e métodos", ExemploEnum.Executar },
                {"Struct - Classes e métodos", Struct.Executar },
                {"Struct x Classe - Classes e métodos", StructVsClasse.Executar },
                {"ValorVsReferencia - Classes e métodos", ValorVsReferencia.Executar },
                {"Parametros Por Referencia - Classes e métodos", ParametrosPorReferencia.Executar },
                {"Parametro Padrão - Classes e métodos", ParametroPadrao.Executar },
                // Coleções
                {"Execução Array - Coleções", ExecucaoArray.Executar },
                {"Execução Lista - Coleções", ExecucaoList.Executar },
                {"Execução ArrayList - Coleções", ExecucaoArrayList.Executar },
                {"Execução Set - Coleções", ExecucaoSet.Executar },
            });
        central.SelecionarEExecutar();
        }
    }
}