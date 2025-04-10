using System;
using System.Globalization ; // Para usar o CultureInfo.InvariantCulture, que é usado para formatar números em uma cultura específica.

namespace CursoCSharp.Fundamentos{

    class FormatandoNumero{

        public static void Executar(){
            double valor = 15.175;

            Console.WriteLine(valor.ToString("F1")); // 15.2 - 1 casa decimal
            Console.WriteLine(valor.ToString("C")); // R$ 15,18 - moeda local
            Console.WriteLine(valor.ToString("P")); // 1.517,50 % - porcentagem
             
            CultureInfo cultura = new CultureInfo("pt-br");
            Console.WriteLine(valor.ToString("C3", cultura)); // R$ 15,175 - moeda local com 3 casas decimais

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // 000025600 - inteiro com 10 casas decimais

        }

    }
}