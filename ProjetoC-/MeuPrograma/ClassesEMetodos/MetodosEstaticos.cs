using System;
using System.Text;
using System.Collections.Generic;

namespace CursoCSharp.ClassesEMetodos{

    public class CalculadoraEstatica {
        // Métodos Estaticos não precisam de instância para serem chamados
        public static int Somar(int a, int b){
            return a + b;
        }

        // Métodos Estaticos não precisam de instância para serem chamados
        public int Multiplicar(int a, int b){
            return a * b;
        }
    }

    class MetodosEstaticos {

        public static void Executar() {
            var resultado = CalculadoraEstatica.Somar (2, 2);
            Console.WriteLine($"Resultado da soma: {resultado}");

            CalculadoraEstatica calc = new CalculadoraEstatica(); // Instância da classe
            Console.WriteLine($"Resultado da Soma: {calc.Multiplicar(2, 2)}"); // Chama o método Multiplicar que não é estático
            // Console.WriteLine($"Resultado da Multiplicação: {CalculadoraEstatica.Multiplicar(2, 2)}"); // Não pode chamar o método Multiplicar que não é estático sem instância
        }

    }
}