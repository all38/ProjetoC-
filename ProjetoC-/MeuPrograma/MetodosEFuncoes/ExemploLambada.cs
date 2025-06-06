using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using CursoCSharp.Fundamentos;

namespace CursoCSharp.MetodosEFuncoes {

    class ExemploLambda{

        public static void Executar(){
                Action algoNoConsole = () => {
                    Console.WriteLine("Lambda com C#!");
            };

            algoNoConsole();
            Console.WriteLine(algoNoConsole);

            Func<int> jogarDado = () => {
                Random random = new Random();
                return random.Next(1,7);
            };

            Console.WriteLine(jogarDado());

            Func<int, String> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia,mes,ano) 
                => String.Format("{0,D2}/{1:D2}/{2:D2}",dia,mes,ano);

            Console.WriteLine(formatarData(1,1,2019));
        }
                
    };
}