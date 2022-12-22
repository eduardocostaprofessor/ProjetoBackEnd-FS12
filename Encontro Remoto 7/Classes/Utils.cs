using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPessoaFS12.Classes
{
    public static class Utils
    {
        public static void Loading(string texto, int qtdPontos, int tempo, ConsoleColor corFonte = ConsoleColor.White, ConsoleColor corFundo = ConsoleColor.Black)
        {
            Console.BackgroundColor = corFundo;// cor de fundo
            Console.ForegroundColor = corFonte;// cor da fonte

            Console.Write(texto);

            for (int i = 1; i <= qtdPontos; i++)
            {
                Console.Write($".");
                Thread.Sleep(500);
            }
            Console.ResetColor();// reseta as cores
        }

        public static void ParadaNoConsole(string texto, ConsoleColor corFonte = ConsoleColor.White)
        {
            Console.ForegroundColor = corFonte;// cor da fonte
            Console.WriteLine(texto);
            Console.WriteLine($"Tecle <ENTER> para continuar");
            Console.ResetColor();
            Console.ReadLine();//parada no sistema
        }
    }
}