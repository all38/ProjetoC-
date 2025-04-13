using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CursoCSharp.ClassesEMetodos{
    
    class Membros {

        public static void Executar(){
            Pessoa sicrano = new Pessoa();  // instanciando a classe pessoa
            sicrano.Nome = "Sicrano";       // atribuindo valor ao atributo Nome da classe pessoa
            sicrano.idade = 20;             // atribuindo valor ao atributo idade da classe pessoa

            Console.WriteLine(sicrano.Nome + " tem " + sicrano.idade + " anos"); // imprimindo os valores dos atributos da classe pessoa
        
            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.idade = 45;

            var apresentacaoDoFulano = fulano.Apresentar();
        }
    }
}