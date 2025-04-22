using System;
using System.Collections; // Precisa tirar o Generic apra funcionar 
using System.Text;

namespace CursoCSharp.Colecoes{

    class ExecucaoArrayList{

        public static void Executar(){
            var arrayList = new ArrayList{ "Palavra", 3, true };
        
            arrayList.Add(3.14);
        
            foreach (object item in arrayList) {
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }
        }
    }
}