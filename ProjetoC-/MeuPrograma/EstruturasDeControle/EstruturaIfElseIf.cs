using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle{

    class estruturaIfElseIf{

        public static void Executar(){
            Console.WriteLine("Digite a nota do aluno: ");

            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if(nota >= 9.0){
                Console.WriteLine("Quadro de honra! ");
            } else if (nota >= 7.0 && nota < 9.0) {
                Console.WriteLine("Aprovado");
            } else if (nota >= 5 && nota < 7.0){
                Console.WriteLine("Zé ruela estude mais pó, só " + nota + " !, vai conquistar seus sonhos como ?");
            }

            Console.WriteLine("Bom esse é o fim! até a proxima fellas...");
        }
    }
}
