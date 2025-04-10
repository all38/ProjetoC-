using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Fundamentos{

    class Inferencia {

        public static void Executar() {
            var nome = "Leonardo davinci";
            Console.WriteLine("Diga um dos maiores inventores da História: " + nome);

            /* em C# não é possivel setar uma variavel sem dar valor a ela
            
            var a;
            a = 1;
            
            */
            var a = 1;

            var b = a + 3;
            Console.WriteLine("Diga o resultado de a + b : " + (a + b));
        }
    }
}