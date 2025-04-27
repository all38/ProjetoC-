using System;
using System.IO;

namespace CursoCSharp.Api {

    class LendoArquivos {

        public static void Executar () {
            var path = @"~/Lendo_Arquivos.txt". ParseHome();

            if(File.Exists(path)){
                using (StreamWriter sw = File.AppendText(path)) {
                    sw.WriteLine("Produto;Preco;Qtde");
                    sw.WriteLine("Caneta bic;3.50;100");
                    sw.WriteLine("Uisque da malasia raro;10200;83");
                }
            }

            try {
                using (StreamReader sr = new StreamReader(path)) {
                    var texto = sr.ReadToEnd ();
                    Console.WriteLine (texto);
                }
            } catch (Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
}