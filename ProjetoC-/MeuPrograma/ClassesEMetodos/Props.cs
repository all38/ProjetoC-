using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class CarroOpcional {
        double desconto = 0.1;

        string nome;
        public string Nome{
            get {return "Opcional: " + nome;} // get = leitura
            set {nome = value;} // set == setamento de valor 
        }

        // Propriedade autoimplementada
        public double Preco{ get; set; }

        // Somente Leitura
        public double PrecoComDesconto {
            get => Preco - (desconto * Preco); // lambida
            // get { return Preco - (desconto * Preco); }
            // set {}
        }

        public CarroOpcional(){

        }

        public CarroOpcional(string nome, double preco){
            this.nome = nome;
            // Nome = nome;
            Preco = preco;
        }
    }
    class Props {

        public static void Executar(){
            var op1 = new CarroOpcional("Ar Condicionado", 3499.9);
            Console.WriteLine(op1.Nome + " " + op1.PrecoComDesconto);

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 2349.2;
            
            Console.WriteLine(op2.Nome + " " + op2.Preco);
        }

    }
}


