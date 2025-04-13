using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaForEach
    {
        public static void Executar()
        {
           var palavra = "Opá!";

            foreach (var letra in palavra){
                Console.WriteLine(letra);
            }

            var alunos = new string[]{ "Ana", "Bia", "Carlos", "Daniel", "Emanuel", "Felicity", "Gustavo", "Hugo", "Igor", "Joaquim"};
            foreach (var aluno in alunos){
                Console.WriteLine(aluno);
            }
        }
    }
}