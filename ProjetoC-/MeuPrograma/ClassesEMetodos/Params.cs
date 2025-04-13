using System;
using System.Text;
using System.Collections.Generic;

namespace CursoCSharp.ClassesEMetodos {

    class Params {

        public static void Recepicionar(params string [] pessoas){
            foreach (var pessoa in pessoas) {
                Console.WriteLine($"Olá {pessoa}!");
            }
        }
        public static void Executar() {
            Recepicionar("João", "Maria", "José", "Ana", "Carlos", "Fernanda", "Lucas", "Patrícia", "Roberto", "Juliana");
        }

    }
}