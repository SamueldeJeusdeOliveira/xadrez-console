namespace tabuleiro{
    class Peca{
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tabuleiro){
            this.posicao = posicao;
            this.cor = cor;
            tab = tabuleiro;
            this.qteMovimentos = 0;
        }

    }
}