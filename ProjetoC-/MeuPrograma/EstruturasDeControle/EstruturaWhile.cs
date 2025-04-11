using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle{

    class EstruturaWhile {

        public static void Executar() {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1,10);
            bool numeroEncontrado = false;
            int tentativaRestantes = 5;
            int tentativas = 0;
            while (tentativaRestantes >0 && !numeroEncontrado){
                Console.WriteLine("Insira o seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                ++tentativas;
                --tentativaRestantes;

                if (numeroSecreto == palpite){
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;

                    Console.WriteLine("Número encontrado em {0} tentativas!", tentativas);
                    Console.WriteLine("Bom Palpite!");

                    Console.BackgroundColor = corAnterior;
                } else if (palpite > numeroSecreto) {
                    Console.WriteLine("Número menor pó..... tenta dv");
                    Console.WriteLine("Tentativas restantes.... {0}", tentativaRestantes);
                } else {
                    Console.WriteLine("Número maior carai..... tenta dv");
                    Console.WriteLine("Tentativas restantes.... {0}", tentativaRestantes);
                }
            }
        }
    }
}
