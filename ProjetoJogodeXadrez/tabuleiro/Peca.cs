using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get;protected set; }
        public int qntmovimentos { get;protected set; }
        public Tabuleiro tab { get; set; }


        public Peca( Cor cor, Tabuleiro tab)
        {
            this.posicao = null;
            this.cor = cor;
            this.qntmovimentos = 0;
            this.tab = tab;

        }
    }


}

    
