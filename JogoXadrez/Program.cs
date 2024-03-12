using JogoXadrez.tabuleiro;
using System;
using JogoXadrez.xadrez;



namespace JogoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {

            //PosicaoXadrez pos = new PosicaoXadrez('a', 1);


            //Console.WriteLine(pos);
            //Console.WriteLine(pos.toPosicao());




            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 2));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));


                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));


                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}