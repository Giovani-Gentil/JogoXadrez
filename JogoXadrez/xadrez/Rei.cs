using JogoXadrez.tabuleiro;
using JogoXadrez.xadrez;
using System;


namespace JogoXadrez.xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(cor, tab)
        {

        }
        public override string ToString()
        {
            return "R";
        }
    }
}
