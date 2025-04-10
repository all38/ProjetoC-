using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {

    class NotacaoPonto {

        public static void Executar(){
            var saudacao = "Olá".ToUpper().Insert(3," World!").Replace("World!" , "Mundo!"); 
            // usa-se para redefinir ou substituir uma palavra em uma string
            Console.WriteLine(saudacao); // imprime uma string formatada com o método ToUpper() e Insert()

            Console.WriteLine("Teste".Length); // imprime o tamanho da string "Teste" com o método Length

            string ValorImportante = null; // variável do tipo string com valor nulo

            Console.WriteLine(ValorImportante?.Length); // imprime o tamanho da string ValorImportante, que é nula, resultando em erro de execução
        }   
    }
}
