using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace tabuleiro
{
    class Peca
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
    }
}
