using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimento { get; protected set; }
        public Tabuleiro Tab { get; set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            Cor = cor;
            Tab = tab;
            QteMovimento = 0;
        }

        public void incrementaQteMoviment()
        {
            QteMovimento++;
        }

        public void DecrementaQteMoviment()
        {
            QteMovimento--;
        }

        public abstract bool[,] MovimentosPossiveis();

        public bool ExisteMovimentoPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for (int l = 0; l < Tab.Linhas; l++)
            {
                for (int c = 0; c < Tab.Colunas; c++)
                {
                    if (mat[l,c])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool PodeMoverPara(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }
    }
}
