using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {


    public class Cliente {
        public string Nome;
        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento){
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNacimento(){
            return string.Format("{0}/{1}/{2}", Nascimento.Day,Nascimento.Month,Nascimento.Year);
        }
    }
    class Readonly{
    
        public static void Executar(){
            var novoCliente = new Cliente("Ana silva", new DateTime(1987, 5, 23));

            Console.WriteLine(novoCliente.Nome + " " + novoCliente.GetDataDeNacimento());   
        }
    }
}