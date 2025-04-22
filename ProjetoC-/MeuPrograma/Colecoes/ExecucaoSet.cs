using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {

    class ExecucaoSet {
        public static void Executar() {
            var livro = new Produto("Tralaleito tralala", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Camisa", 28.3), 
                new Produto("8° Temporada", 123.2),
                new Produto("Livro Do Milenio", 10000000000.3)
            };

            carrinho.UnionWith(combo); 
            Console.WriteLine(carrinho.Count); 
            //carrinho.RemoveAt(3);

            foreach (var item in carrinho) {
                //Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine( carrinho.Count );
            carrinho.Add(livro);
            Console.WriteLine( carrinho.Count );
        }
    }
}