using BibliotecaDeArquivosDoWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstLibrary {
    class Program {
        static void Main(string[] args) {
            var BibliotecaDoFilipe = new GetFiles();
            string[] Lista = BibliotecaDoFilipe.RetornaArquivosDoMeuDocumentos();
            for (int i = 0; i < Lista.Length; i++) {
                Console.WriteLine(Lista[i]);
            }
            
            string[] ListaGit = BibliotecaDoFilipe.RetornaArquivosGit();
            for (int i = 0; i < ListaGit.Length; i++) {
                Console.WriteLine(ListaGit[i]);

            }
            string[] ListaImg = BibliotecaDoFilipe.RetornaArquivosImagesFiles();
            for (int i = 0; i < ListaImg.Length; i++) {
                Console.WriteLine(ListaImg[i]);

            }

            Console.ReadKey();
        }
    }
}
