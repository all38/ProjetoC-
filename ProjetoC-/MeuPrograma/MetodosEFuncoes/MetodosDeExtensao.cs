using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {

    public static class ExtensaoInteiro {
        public static int Soma (this int num, int outroNumero) {
            return num + outroNumero;
        }

        public static double Subtracao (this double num, double outroNumero) {
            return num - outroNumero;
        }
    }

    class MetodosDeExtensao {

        public static void Executar () {
        
        int numero = 5;
        double numeroReal = 5.5;

        Console.WriteLine (numero.Soma(3));
        Console.WriteLine (numeroReal.Subtracao(10));

        Console.WriteLine (2.Soma(3));
        Console.WriteLine (2.9.Subtracao(6.7));

        }
    }
}