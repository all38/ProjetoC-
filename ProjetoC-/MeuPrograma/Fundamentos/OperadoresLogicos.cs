using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {

    class OperadoresLogicos {

        public static void Executar(){
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            bool comprouSorvete = executouTrabalho1 && executouTrabalho2; // E // true && false = false                   
            Console.WriteLine("Comprou Sorvete? {0}", comprouSorvete);
            
            var comprouTv50 = executouTrabalho1 || executouTrabalho2; // OU // true || false = true
            Console.WriteLine("Comprou a TV ? {0}", comprouSorvete);
            
            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2; // OU Exclusivo // true ^ false = true
            Console.WriteLine("Comprou a Tv 32? {0}", comprouTv32);

            Console.WriteLine("Mais saudavel? {0}", !comprouSorvete);

        }
    }
}