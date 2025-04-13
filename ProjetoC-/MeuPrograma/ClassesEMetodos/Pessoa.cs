using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CursoCSharp.ClassesEMetodos{
    
    class Pessoa {

        public string Nome; // método público, acessível de fora da classe
        public int idade;   // método público, acessível de fora da classe

        public string Apresentar() { // método público, acessível de fora da classe
            return string.Format($"Olá, meu nome é {Nome} e tenho {idade} anos.");
        } // método público, acessível de fora da classe

        public void ApresentarNoConsole() { // método público, acessível de fora da classe
            Console.WriteLine(Apresentar()); // chamando o método Apresentar dentro do método ApresentarNoConsole
        } // método público, acessível de fora da classe
        
    }
}
