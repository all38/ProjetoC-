using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {


    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia };

    public class Filme{
        public string Titulo;
        public Genero GeneroFilme;

    }

    class ExemploEnum {

        public static void Executar(){
            int id = (int)Genero.Acao;
            Console.WriteLine(id);

            var filmeFamilia = new Filme();
            filmeFamilia.Titulo = "Sharkneado 34²";
            filmeFamilia.GeneroFilme = Genero.Comedia;   

            Console.WriteLine("{0} é {1}!", filmeFamilia.Titulo,filmeFamilia.GeneroFilme);
        }
    }
}
