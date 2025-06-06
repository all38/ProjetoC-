using System;
using System.Text;
using System.Collections.Generic;

namespace CursoCSharp.ClassesEMetodos{

    public class Produto {
        public string Nome;
        public double Preco;
        public double Desconto = 0.1;

        public Produto (string nome, double preco, double desconto) {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }
        
        public Produto() {

        }
        
        public double CalcularDesconto() {
            return Preco - (Preco * Desconto);
        }
    }


    class AtributosEstaticos {
        public static void Executar() {
            // Atributos Estaticos
            var produto1 = new Produto("Caneta", 3.20, 0.5);

            var produto2 = new Produto(){
                Nome = "Borracha",
                Preco = 2.50,
                Desconto = 0.1
            };
            
            Console.WriteLine("Preço com desconto: " + produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: " + produto2.CalcularDesconto());
        }
    }
}
