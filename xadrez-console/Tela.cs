using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int l = 0; l < tab.Linhas; l++)
            {
                Console.Write($"{8 - l} ");
                for (int c = 0; c < tab.Colunas; c++)
                {
                    ImprimePeça(tab.Peca(l, c));
                }
                Console.WriteLine();
            }
            Console.Write("  A B C D E F G H");
        }

        public static void imprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoAtual = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int l = 0; l < tab.Linhas; l++)
            {
                Console.Write($"{8 - l} ");
                for (int c = 0; c < tab.Colunas; c++)
                {
                    if (posicoesPossiveis[l,c])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoAtual;
                    }
                    ImprimePeça(tab.Peca(l, c));
                }
                Console.WriteLine();
            }
            Console.Write("  A B C D E F G H");
            Console.BackgroundColor = fundoAtual;
        }

        private static void ImprimePeça(Peca peca)
        {
            if(peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.Cor == Cor.Branca)
                    Console.Write($"{peca} ");
                else
                {
                    ConsoleColor consoleColororiginal = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"{peca} ");
                    Console.ForegroundColor = consoleColororiginal;
                }
            }

            
        }

        public static PosicaoXadres LerPosicaoXadrez() 
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1]+"");
            return new PosicaoXadres(coluna, linha);
        }

    }
}
