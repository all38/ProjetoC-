using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos { 

    class VariaveisEConstantes {

        public static void Executar(){
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);
            
            // Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade é " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("O menor valor int é " + menorValorInt);

            uint populacaoBrasileira = 207_600_00;
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial é " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("O Preço do computador é " + precoComputador);
        
            double valorDeMercadoDaAplle = 100000000000000.00;
            Console.WriteLine("O Valor de mercado da Apple é " + valorDeMercadoDaAplle);

        }
    }
}

