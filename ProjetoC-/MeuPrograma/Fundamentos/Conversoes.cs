using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos{

    class Conversoes {

        public static void Executar(){
            int inteiro = 10;
            double quebrado = inteiro; // Conversão implícita (upcasting)
            Console.WriteLine(quebrado); // 10

            double nota = 9.7;
            // int notaTruncada = nota; // Conversão implícita (upcasting) não compila
            int notaTruncada = (int)nota; // Conversão explícita (downcasting)
            Console.WriteLine("Nota truncada: {0} ", notaTruncada); // 9
 
            Console.Write("Digite sua idade: ");
            string idadeGafanhotoString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeGafanhotoString); // Conversão explícita (downcasting)
            Console.WriteLine("Idade inserida: {0} ", idadeInteiro); 

            idadeInteiro = Convert.ToInt32(idadeGafanhotoString); // Conversão explícita (downcasting)
            Console.WriteLine("Idade inserida: {0} ", idadeInteiro);

            Console.WriteLine("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1); // Conversão explícita (downcasting)
            Console.WriteLine("Resultado 1: {0} ", numero1); // 0 se não for um número

            Console.WriteLine("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2); // Conversão explícita (downcasting)
            // int.TryParse(Console.ReadLine(), out var numero2); // Conversão explícita (downcasting)
            Console.WriteLine("Resultado 2: {0} ", numero2); // 0 se não for um número


        }
    }
}