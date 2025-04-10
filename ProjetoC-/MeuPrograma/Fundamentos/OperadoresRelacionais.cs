using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos{

    class OperadoresRelacionais {

        public static void Executar(){
            double nota = 6.0;
            double notaDeCorte = 7;

            Console.WriteLine("Nota invalida ? {0}", nota > 10 || nota < 0);    // Verifica se a nota é maior que 10 ou menor que 0
            Console.WriteLine("Nota invalida ? {0}", nota > 10 || nota > 0);    // Verifica se a nota é maior que 10 ou maior que 0
            Console.WriteLine("Perfeito ? {0}", nota == 10);                    // Verifica se a nota é igual a 10
            Console.WriteLine("tem que melhorar ? {0}", nota != 10);            // Verifica se a nota é diferente de 10
            Console.WriteLine("Aprovado ? {0}", nota >= notaDeCorte);           // Verifica se a nota é maior ou igual a nota de corte
            Console.WriteLine("Recuperação ? {0}", nota < notaDeCorte);         // Verifica se a nota é menor que a nota de corte
            Console.WriteLine("Reprovado ? {0}", nota <= 3.0);                  // Verifica se a nota é menor ou igual a 3.0
        }
    }
}