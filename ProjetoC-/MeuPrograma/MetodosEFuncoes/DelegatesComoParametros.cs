using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {

    class DelegatesComoParametro {

        public delegate int Operacao (int x, int y);

        public static int Soma (int x, int y) {
            return x + y;
        }

        public static string Calculadora (Operacao op, int x, int y) {
            var resultado = op (x,y);
            return "Resultado: " + resultado;
        }

        public static void Executar () {
            
            Operacao subtracao = (int x, int y) => x - y;
            Console.WriteLine (Calculadora(subtracao, 3, 3));

            Console.WriteLine (Calculadora(Soma, 3, 3));
        }
    }
}