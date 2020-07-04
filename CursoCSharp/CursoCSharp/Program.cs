using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

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

                // Módulo 04 - Coleçōes

                {"Array - Coleçōes", Colecoes.Array.Executar },
                {"List - Coleçōes", Colecoes.List.Executar },

                // Módulo 05 - Orientação a Objetos

                // Módulo 06 - Métodos e Funçōes

                // Módulo 07 - Execçōes

                // Módulo 08 - Explorando API

                // Módulo 09 - Tópicos Avançados


            });
             
            central.SelecionarEExecutar();
        }
    }
}