using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {

    class EstruturaDoWhile {

        public static void Executar() {

            string entrada;

            do {
                Console.WriteLine("Qual o seu nome?:");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem-vindo: {0}", entrada);
                Console.WriteLine("Quer continuar (S/N)?");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s");
        }
    }
}
