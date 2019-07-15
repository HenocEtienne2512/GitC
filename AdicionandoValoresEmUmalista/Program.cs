using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Manualmente
namespace AdicionandoValoresEmUmalista {
    class Program {
        static void Main(string[] args) {
            string[,] listaDeNome = new string[10, 2];
            int IdParaLista = 0;
            for (int i = 0; i < listaDeNome.GetLength(0); i++) {
                Console.WriteLine("Informe um nome para adicionar um registro:");
                var nome = Console.ReadLine();

                listaDeNome[i, 0] = (IdParaLista++).ToString();
                listaDeNome[i, 1] = nome;

                Console.WriteLine("Deseja inserir um novo registro? sim(1) não(0)");
                var continua = Console.ReadKey().KeyChar.ToString();

                if (continua == "0") {
                    break;

                }
               
            }
            Console.WriteLine("registro adicionado com sucesso, segue a lista de informação adicinada");

            for (int i = 0; i < listaDeNome.GetLength(0); i++) {
                Console.WriteLine(string.Format("Registro ID{0} - Nome: {1}", listaDeNome[i, 0], listaDeNome[i, 1]));
            }
            Console.ReadKey();
        }

        public static void InsereRegistro() {

        }
    }
}
