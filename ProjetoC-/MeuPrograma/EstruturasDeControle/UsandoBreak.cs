using System;
using System.Collections.Generic;
using System.Text;  

namespace CursoCSharp.Fundamentos{

    class UsandoBreak{
        public static void Executar(){
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine($"Número sorteado: {numero}");
            
            for (int i = 1; i <= 50; i++){
                Console.WriteLine("{0} é o número que queremos?", i);
                if (i == numero){
                    Console.WriteLine("sim!");
                    break;
                } else {
                    Console.WriteLine("não!");
                }
            }
            Console.WriteLine("Fim do programa!");
       }
    }
}
