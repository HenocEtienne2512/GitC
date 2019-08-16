using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimples.Mostrar {
    class MostrarLista {
        public void PesquisandoInformacoesNaNossaLista(string[,] arrayBi, string pId) {
            for (int i = 0; i < arrayBi.GetLength(0); i++) {
              
                if (arrayBi[i, 0] == pId) {//Mostramos as informações formatadas da nossa pesquisa
                    Console.WriteLine($"Informação escolhida: Id:{arrayBi[i, 0]} - Nome:{arrayBi[i, 1]}");
                    
                    return;
                }
            }

            //Caso ele passe por esta linha identificamos que ele não encontrou resultados compativeis.
            Console.WriteLine("Infelizmente a busca pelo id não resultou em nenhuma informação.");
        }
    }
}
