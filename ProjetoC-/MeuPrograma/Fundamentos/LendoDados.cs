using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {

    class LendoDados {
        public static void Executar() {
            Console.Write("qual é seu nome pequeno Gafanhoto? ");// o Console.Write() imprime na tela, mas não pula para a próxima linha
            string nomeGafanhoto = Console.ReadLine();  // Lê o nome do usuário com o metodo ReadLine()
            Console.WriteLine("seja bem vindo ao curso de C# " + nomeGafanhoto + "!");  

            Console.Write("Qual a sua Idade pequeno ? ");
            int idadeGafanhoto = int.Parse(Console.ReadLine()); // Lê a idade do usuário com o metodo ReadLine()
            Console.WriteLine("A idade do gafanhoto é " + idadeGafanhoto + " anos!");

            Console.Write("Qual o seu salário ? ");// o Console.Write() imprime na tela, mas não pula para a próxima linha
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture); // Lê o salário do usuário com o metodo ReadLine()
            Console.Write($"{nomeGafanhoto} {idadeGafanhoto} R${salario}");

        }
    }

}