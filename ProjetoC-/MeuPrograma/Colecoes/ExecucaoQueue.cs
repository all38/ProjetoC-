using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes{

    class ExecucaoQueue{

        public static void Executar(){
            var fila = new Queue<string>(); 
                
            fila.Enqueue("Rogerinho fenomeno");
            fila.Enqueue("Mestres dos magos");
            fila.Enqueue("Campeão do F1 2023");
            fila.Enqueue("Jason sexta feira 13");
            fila.Enqueue("T-rex de braço longo");

            Console.WriteLine(fila.Peek()); // pegar o primeiro elemento da fila 
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue()); // elimina o primeiro da fila
            Console.WriteLine(fila.Count);

            foreach ( var pessoa in fila ) {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
              salada.Enqueue(3);
              salada.Enqueue("Item");
              salada.Enqueue(true);
              salada.Enqueue(30.2);
            
            Console.WriteLine(salada.Contains("Item"));
        }

    }
}