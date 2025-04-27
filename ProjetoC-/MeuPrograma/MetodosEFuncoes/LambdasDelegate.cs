using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {

    delegate double Operacao (double x, double y);

    class LambdaDelegate {

        public static void Executar () {
            // delegate determina um tipo que armazena uma assinatura de uma função
            Operacao sum    = (x,y) => x + y;
            Operacao sub    = (x,y) => x - y;
            Operacao mult   = (x,y) => x * y;

            Console.WriteLine(sum   (3,2));
            Console.WriteLine(sub   (3,2));
            Console.WriteLine(mult  (3,2));


        }
    }
}