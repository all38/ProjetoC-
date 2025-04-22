using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {

    class ExecucaoArray {

        public static void Executar(){
            string [] alunos = new string[5];
            alunos[0] = "Rogerio Cena"; 
            alunos[1] = "Rogerio Silva";
            alunos[2] = "Rogerio Santos";
            alunos[3] = "Rogerio Almeida";
            alunos[4] = "Rogerio Oliveira";
            // estrutura de array e do tipo indixidada o que significa que o acesso aos elementos é feito através de um índice.
            // e índice é um número inteiro que representa a posição do elemento no array.
            // o primeiro elemento do array tem índice 0, o segundo elemento tem índice 1, e assim por diante.

            // o array é uma estrutura de dados que armazena uma coleção de elementos do mesmo tipo.
            
            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }
            
            double somatorio = 0;
            double [] notas = { 9.5, 8.5, 7.5, 6.5, 5.5 };

            foreach (var nota in notas) {
                somatorio += nota;
            }
            // o foreach é uma estrutura de controle que permite percorrer os elementos de uma coleção, como um array ou uma lista.
            double media = somatorio / notas.Length;
            Console.WriteLine($"A média é: {media}");
            
            char [] letras = {'A', 'r', 'r', 'e', 'y'};
            string palavra = new string(letras);
            // o new string é um construtor que cria uma nova string a partir de um array de caracteres.
            Console.WriteLine($"A palavra é: {palavra}");
        }
    }
}