using System;
using System.IO;

namespace CursoCSharp.Api {

    class ExemploDiretorios {

        public static void Executar () {
            
            var dirProjeto = "~/source/repos/CursoCSharp/CursoCSharp".ParseHome();

            var dirInfo = new DirectoryInfo(dirProjeto);

            if (!dirInfo.Exists) {
                dirInfo.Create();
            }

            Console.WriteLine("== Arquivos ==");
            var arquivos = dirInfo.GetFiles();

            foreach (var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n=== Diretorios ====");
            var pastas = dirInfo.GetDirectories();
            foreach (var pasta in pastas) {
                Console.WriteLine(pasta);
            }
        }
    }
}