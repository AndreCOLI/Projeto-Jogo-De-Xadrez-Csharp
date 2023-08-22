using System;
using tabuleiro;
using xadrez;

namespace ProjetoJogodeXadrez
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {


                Tabuleiro tab = new Tabuleiro(8, 8);


                tab.colocarPeca(new Torre(tab, Cor.preta), new Posicao(1, 1));
                tab.colocarPeca(new Rei(tab, Cor.preta), new Posicao(2, 7));

                Tela.imprimirTabuleiro(tab);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            
            }
    }
}
