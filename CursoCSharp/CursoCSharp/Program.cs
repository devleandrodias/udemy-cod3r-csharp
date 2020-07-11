using System;
using System.Collections.Generic;
using CursoCSharp.ClassesMetodos;
using CursoCSharp.Fundamentos;
using CursoCSharp.MetodosFuncoes;
using CursoCSharp.API;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp
{
    class Program
    {
        /*
         * Quando for chamar sua aplicação por linha de comando
         * os args vão ser os parametros vão estar contidos em 
         * args Ex. --no-verbose args.noVerbose = true
         */
        static void Main()
        {
            CentralDeExercicios central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Módulo 01 - Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comanentários - Fundamentos", Comentarios.Executar},
                {"Váriaveis e Constantes - Fundamentos", VariaveisConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados Console - Fundamentos", LendoDadosConsole.Executar },
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar },
                {"Conversōes - Fundamentos", Conversoes.Executar },
                {"Operadores Aritméticos - Fundamentos", OperadoresArimeticos.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar },
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar },
                {"Operadores Ternário - Fundamentos", OperadoresTernarios.Executar },

                // Módulo 02 - Estruturas de Controle

                // Módulo 03 - Classes e Métodos

                {"Membros e Métodos - Classes e Métodos", Membros.Executar },
                {"Construtores - Classes e Métodos", Construtores.Executar },
                {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar },
                {"Métodos Estáticos - Classes e Métodos", MetodosEstatico.Executar },
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar },
                {"Desafio Atributos - Métodos e Funçōes", DesafioAtributo.Executar },
                {"Params - Métodos e Funçōes", Params.Executar },
                {"Params Nomeados - Métodos e Funçōes", ParamsNomeados.Executar },
                {"Getters and Setters - Métodos e Funçōes", GetSet.Executar },

                // Módulo 04 - Coleçōes

                {"Array - Coleçōes", Colecoes.Array.Executar },
                {"List - Coleçōes", Colecoes.List.Executar },
                {"ArrayList - Coleçōes", Colecoes.ColecoesArrayList.Executar },
                {"Set - Coleçōes", Colecoes.Set.Executar },
                {"Fila - Coleçōes", Colecoes.Fila.Executar },
                {"Igualdade - Coleçōes", Colecoes.Igualdade.Executar },
                {"Stack - Coleçōes", Colecoes.ColecaoStack.Executar },
                {"Dicionário - Coleçōes", Colecoes.Dicionario.Executar },

                // Módulo 05 - Orientação a Objetos

                // Módulo 06 - Métodos e Funçōes

                {"Lambdas - Métodos e Funçōes", ExemploLambda.Executar },
                {"Lambdas Delegate - Métodos e Funçōes", LambdasDelegate.Executar },
                {"Usando Delegate - Métodos e Funçōes", UsandoDelegate.Executar },
                {"Delegate Funçōes Anônimas - Métodos e Funçōes", DelegateFuncAnonima.Executar },
                {"Delegate Com Parâmetros - Métodos e Funçōes", DelegateComParametros.Executar },
                {"Métodos de Extensão - Métodos e Funçōes", MetodosExtensao.Executar },

                // Módulo 07 - Execçōes

                // Módulo 08 - Explorando API

                {"Primeiro Arquivo - Explorando API C#", PrimeiroArquivo.Executar },

                // Módulo 09 - Tópicos Avançados

                {"LINQ #01 - Tópicos Avançados", Linq1.Executar },
                {"LINQ #02 - Tópicos Avançados", Linq2.Executar },
                {"Nullables - Tópicos Avançados", ExemploNullable.Executar },
                {"Dynamics - Tópicos Avançados", ExemploDynamics.Executar },
                {"Exemplo Genéricos - Tópicos Avançados", ExemploGenerics.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}