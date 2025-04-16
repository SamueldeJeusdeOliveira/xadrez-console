using tabuleiro;

namespace xadrez_console{
    class Tela{
        public static void imprimirTabuliero(Tabuleiro tab){
            for(int i = 0; i <tab.linhas;i++){
                for(int j =0; j<tab.colunas;j++){
                    if(tab.peca(i,j) == null){
                    System.Console.Write(tab.peca(i,j) + "- ");
                    }
                    else{
                        System.Console.Write(tab.peca(i,j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}