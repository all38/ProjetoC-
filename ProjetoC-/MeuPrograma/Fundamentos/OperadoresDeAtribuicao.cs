using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {

    class OperadoresDeAtribuicao{

        public static void Executar(){
            var num1 = 3;
            num1 = 7;
            num1 += 10; // num1 = num1 + 10
            num1 -= 3;
            num1 *= 5;
            num1 /= 2;

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++; // ++ atribuição a = a + 1
            b--; // -- atribuição b = b - 1

            Console.WriteLine($"{a} {b}");

            // não se preucupe com o código
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "Jão";

            dynamic d = c;
            d.nome = "maria";

            Console.WriteLine(c.nome);
        }
    }
}