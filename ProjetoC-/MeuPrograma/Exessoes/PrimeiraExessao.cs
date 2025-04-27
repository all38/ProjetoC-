using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Exessoes {

    public class Conta {
        double Saldo;

        public Conta (double saldo) {
            Saldo = saldo;
        }

        public void Sacar (double valor) {
            if (valor > Saldo){
                throw new ArgumentException ("carma moreno tá alguma coisa errada!, olha o saldo");
            }
            Saldo -= valor;
        }
    }

    class PrimeiraExessesao {

        public static void Executar () {
            var conta = new Conta (1223.42);

            try {
                conta.Sacar(1000);
                Console.WriteLine ("Retirada com sucesso!");
            } catch (Exception ex) {
                Console.WriteLine (ex.Message);
            } finally {
                Console.WriteLine ("Obrigado!");
            }

        }
    }
}