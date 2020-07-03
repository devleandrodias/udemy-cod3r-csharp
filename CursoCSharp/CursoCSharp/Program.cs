using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp
{
    class Program
    {
        static void Main()
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comanentários - Fundamentos", Comentarios.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados Console - Fundamentos", LendoDadosConsole.Executar },
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar },
                {"Conversōes - Fundamentos", Conversoes.Executar },
            });
             
            central.SelecionarEExecutar();
        }
    }
}