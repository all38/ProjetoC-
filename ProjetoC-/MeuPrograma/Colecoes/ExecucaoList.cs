using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {

    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj) {
            Produto outro = (Produto)obj;
            bool mesmoNome = Nome == outro.Nome;
            bool mesmoPreco = Preco == outro.Preco;
            return mesmoNome && mesmoPreco;
        }

        public override int GetHashCode() {
            return Nome.Length;
        }
    }

    class ExecucaoList {
        public static void Executar() {
            var livro = new Produto("Tralaleito tralala", 49.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto> {
                new Produto("Camisa", 28.3), 
                new Produto("8° Temporada", 123.2),
                new Produto("Livro Do Milenio", 10000000000.3)
            };

            carrinho.AddRange(combo); 
            Console.WriteLine(carrinho.Count); 
            carrinho.RemoveAt(3);

            foreach (var item in carrinho) {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            
        }
    }
}