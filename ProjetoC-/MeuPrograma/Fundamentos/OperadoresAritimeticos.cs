using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos{

    class OperadoresAritimeticos{

        public static void Executar(){

            // preço com desconto

            var preço = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preço + imposto;
            var totalComDesconto = total - (total * desconto); 
            Console.WriteLine("O preço toal é: {0}", totalComDesconto);

            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / (altura * altura); // o double imc = peso / Math.Pow(altura,2 );
            Console.WriteLine("O IMC é: {0}", imc);

            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2); // 0
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2); // 1

        }

    }
}