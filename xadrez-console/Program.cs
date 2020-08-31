using System;
using System.Security.Cryptography;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    try
                    {
                        Tela.ImprimeInformacoes(partida);

                        Console.WriteLine("Origem");
                        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidaPosicaoOrigem(origem);

                        Console.Clear();
                        bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();
                        Tela.imprimirTabuleiro(partida.Tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.WriteLine("Destino");
                        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                        partida.ValidaPosicaoDestino(origem, destino);

                        partida.RealizaJogada(origem, destino);
                    }
                    catch (TabuleiroException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.ReadLine();
                    }
                    
                }

                
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
