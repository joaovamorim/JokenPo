namespace JokenPo
{
    class Game
    {
        public enum Resultado
        {
            Ganhar, Perder, Empatar
        }

        public static Image[] images = 
        {
            Image.FromFile("imagens/Pedra.png"),
            Image.FromFile("imagens/Papel.png"),
            Image.FromFile("imagens/Tesoura.png")
        };

        public Image ImgJogador { get; private set; }
        public Image ImgPC { get; private set; }


        public Resultado Jogar(int jogador)
        {
            int pc = JogadaPC();

            ImgJogador = images[jogador];
            ImgPC = images[pc];

            if (jogador == pc)
            {
                return Resultado.Empatar;
            }
            else if ((jogador == 0 && pc == 2) || (jogador == 1 && pc == 0) || (jogador == 2 && pc == 1))
            {
                return Resultado.Ganhar;
            }
            else
            {
                return Resultado.Perder;
            }
        }

        private int JogadaPC()
        {
            int milPC = DateTime.Now.Millisecond;

            if (milPC < 333)
            {
                return 0;
            }
            else if (milPC >= 333 && milPC < 667)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}