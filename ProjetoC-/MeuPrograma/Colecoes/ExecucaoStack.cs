using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes {

    class ExecucaoStack {

        public static void Executar(){
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("á lei");
            pilha.Push(5.67865f);
            pilha.Push(true);

            foreach (var itens in pilha){
                Console.WriteLine(itens);
            }

            Console.WriteLine($"\nPeek: {pilha.Pop()}" );
            Console.WriteLine(pilha.Count);
        }
    }
}