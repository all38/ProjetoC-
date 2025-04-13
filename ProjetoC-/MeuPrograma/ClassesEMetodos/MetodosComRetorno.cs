using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    class CalculadortaComum {

        public int Somar(int a, int b){ // Método que recebe dois inteiros e retorna um inteiro
            return a + b; // Retorna o resultado da soma
        }

        public int Subtrair(int c, int d){ // Método que recebe dois inteiros e retorna um inteiro
            return c - d; // Retorna o resultado da subtração
        }

        public int Multiplicar(int e, int f){ // Método que recebe dois inteiros e retorna um inteiro
            return e * f; // Retorna o resultado da multiplicação
        }

        public int Dividir(int g, int h){ // Método que recebe dois inteiros e retorna um inteiro
            return g / h; // Retorna o resultado da divisão
        }

    }

    class CalculadoraCadeia{
        int memoria; // Variável de instância para armazenar o resultado
        public CalculadoraCadeia Somar(int a){ // Construtor que inicializa a memória com um valor inicial
            memoria += a; // Adiciona o valor à memória
            return this; // Retorna a instância atual para permitir o encadeamento de métodos
        }

        public CalculadoraCadeia Subtrair(int b){  // Método para subtrair um valor da memória
            memoria -= b; // Subtrai o valor da memória
            return this; // Retorna a instância atual para permitir o encadeamento de métodos
        }

        public CalculadoraCadeia Multiplicar(int c){ // Método para multiplicar um valor na memória
            memoria *= c; // Multiplica o valor da memória
            return this; // Retorna a instância atual para permitir o encadeamento de métodos
        }

        public CalculadoraCadeia Dividir(int d){ // Método para dividir um valor na memória
            memoria /= d; // Divide o valor da memória
            return this; // Retorna a instância atual para permitir o encadeamento de métodos
        }

        public CalculadoraCadeia Limpar(){ // Método para limpar a memória
            memoria = 0; // Zera a memória
            return this; // Retorna a instância atual para permitir o encadeamento de métodos
        }

        public CalculadoraCadeia Imprimir(){ // Método para imprimir o valor da memória
            Console.WriteLine(memoria); // Imprime o valor da memória
            return this; // Retorna a instância atual para permitir o encadeamento de métodos
        }

        public int Resultado(){ // Método para retornar o resultado final
            return memoria; // Retorna a instância atual para permitir o encadeamento de métodos
        }

    }

    class MetodoComRetorno {

        public static void Executar(){
            var CalculadortaComum = new CalculadortaComum(); // Cria uma instância da classe CalculadortaComum
            var resultado = CalculadortaComum.Somar(10, 5); // Chama o método Multiplicar e armazena o resultado
            
            Console.WriteLine(resultado); // Imprime o resultado da soma
            Console.WriteLine(CalculadortaComum.Multiplicar(10, 5)); // Chama o método Somar e imprime o resultado
            Console.WriteLine(CalculadortaComum.Subtrair(10, 5)); // Chama o método Subtrair e imprime o resultado
        
            var CalculadoraCadeia = new CalculadoraCadeia();
            CalculadoraCadeia.Somar(3).Multiplicar(3).Imprimir() // Chama o método Somar e imprime o resultado
                .Subtrair(2).Dividir(2).Imprimir() // Chama o método Subtrair e imprime o resultado
                .Limpar().Imprimir(); // Chama o método Limpar e imprime o resultado

            Console.WriteLine(resultado);
        }
    }
}