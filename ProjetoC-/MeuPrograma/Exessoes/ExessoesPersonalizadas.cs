using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Exessoes {

    public class NegativoExeception : Exception {
        public NegativoExeception () { }

        public NegativoExeception (string message) : base(message) {}

        public NegativoExeception (string message, Exception inner) : base (message, inner) {}
    }

    public class ImparExeption : Exception {
        public ImparExeption (string message) : base (message) {}
    }

    class ExessoesPersonalizadas {

        public static int PositivoPar () {
            Random random = new Random();
            int valor = random.Next(-30,30);

            if (valor < 0) {throw new NegativoExeception ("Número negativo...(");}
            if (valor % 2 == 1) {throw new ImparExeption ("Número impar...("); }

            return valor;
        }

        public static void Executar () {

            try {Console.WriteLine (PositivoPar());}
            catch (NegativoExeception ex) {Console.WriteLine (ex.Message);}
            catch (ImparExeption ex) {Console.WriteLine (ex.Message);}
            catch (Exception ex) {Console.WriteLine (ex.Message);}
        }
    }
}