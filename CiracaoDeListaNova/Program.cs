using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiracaoDeLista {
    class Program {
        // Versão 2.0 agora com nome correto
        static void Main(string[] args) {
            //Iniciando uma lista de string com array linear
            string[] lista = new string[10]; // aqui definimos as posi~ções da lista iniciando em 10
            //Espaço na memoria para alogar as informações de texto
            for (int i = 0; i < lista.Length; i++) {
                // Carregar valores da lista
                lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:.fff");

            }
            foreach (var item in lista) {
                Console.WriteLine(item);

            }

            Console.ReadKey();
            for (int i = 0; i < lista.Length; i++) {
                lista[i] = string.Empty;
            }
            foreach (var item in lista) {
                Console.WriteLine(item);

            }
            Console.ReadKey();
        }
    }
}
