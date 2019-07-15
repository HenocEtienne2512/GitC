using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiDeManeiraSimples {
    class Program {
        static void Main(string[] args) {
            string[,] listaDeNome = new string[5, 2];
            CarregarInformacoesElasEmTela(ref listaDeNome);

            Console.ReadKey();

            Console.WriteLine("Informe o ID do registro a ser pesquisado.");

            PesquisandoInformacoesnaNossaLista(listaDeNome, Console.ReadLine());
        }

        public static void CarregarInformacoesElasEmTela(ref string[,] arrayBi) {
         
            for (int i = 0; i < arrayBi.GetLength(0); i++) {
                arrayBi[i, 0] = i.ToString();
                arrayBi[i, 1] = $"Henoc_{i}";

            }
            for (int i = 0; i < arrayBi.GetLength(0); i++) {
                Console.WriteLine($"ID:{arrayBi[i, 0]} - Nome{arrayBi[i, 1]}");

            }
            Console.ReadKey();
        }

        public static void PesquisandoInformacoesnaNossaLista(string[,] arrayBi, string pId) {
            for (int i = 0; i < arrayBi.GetLength(0); i++) {
                if (arrayBi[i,0] == pId) {
                    Console.WriteLine($"Informação escolhida: Id:{arrayBi[i,0]} - Nome: {arrayBi[i,1]}");

                    return;
                }
            }
            Console.WriteLine("Infelizmente a busca pelo  id não resulto em nenhuma informação");

            Console.ReadKey();
        }

    }
}

