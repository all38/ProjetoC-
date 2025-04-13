using System;
using System.Text;
using System.Collections.Generic;

namespace CursoCSharp.ClassesEMetodos {

    class DesafioAtributo {
        
        int a = 10;
        public static void Executar() {
            // acessar variavel "a" dentro do método Executar.
            
            var desafio = new DesafioAtributo();
            Console.WriteLine("Atributo: " + desafio.a); // Correto! Acessando o atributo de instância através de uma instância da classe.

            // Console.WriteLine("Atributo: " + a); // Erro! Não é possível acessar um atributo de instância de um método estático.
        }
    }
}