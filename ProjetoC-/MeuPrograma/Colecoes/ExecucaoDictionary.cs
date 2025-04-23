using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes {

    class ExecucaoDictionary {

        public static void Executar() {
            var filmes = new Dictionary<int,string>();
            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-aranha");
            filmes.Add(2012, "2012");

            if (filmes.ContainsKey(2012)){
                Console.WriteLine($"2012 : " + filmes[2012]);
            }

        }
    }
}