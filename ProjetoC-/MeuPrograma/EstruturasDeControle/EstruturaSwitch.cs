using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle{
    
    class EstruturaSwitch {

        public static void Executar() {
            Console.WriteLine("Avalie meu atendimento de 0 a 5");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota) {
                case -1:    Console.WriteLine("Kauan Certeza vei");     break;
                case 0:     Console.WriteLine("Pessimo");               break;
                case 1:     Console.WriteLine("Poderia ser melhor");    break;
                case 2:     Console.WriteLine("Quase bom");             break;
                case 3:     Console.WriteLine("Bom");                   break;
                case 4:     Console.WriteLine("Muito bom");             break;
                case 5:     Console.WriteLine("Exelente");              break;
            }

            if (nota > 5 || nota < -1){
                Console.WriteLine("Pior que kauan não tem não");
            }
            Console.WriteLine("Fim!");
        }
    }
}