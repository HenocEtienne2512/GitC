using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimples.Carrega {
    class CarregaLista {
        public CarregaLista(string[,] arraybi) {

            //Assimos uma lista
            arraybi = new string[10,2];
        }
        public void CarregaInformacoesEListaElasEmTela(string[,] arraybi) {
            
            for (int i = 0; i < arraybi.GetLength(0); i++) {
                //Carregando o que podemos chamar de ID, identificador do nosso registro unico
                arraybi[i, 0] = i.ToString();
                //Aqui apenas adicionamos uma informação extra para deixar legal
                arraybi [i, 1] = $"Felipe_{i}";
            }

            //Lembrando que GetLength é um metodo e usamos "(parametro)" com parametro ou as vezes sem 
            //para realizar a chamada do mesmo
            for (int i = 0; i < arraybi.GetLength(0); i++) {
                //Formatamos uma string de maneira que os dados sejam apresentados 
                Console.WriteLine($"ID:{arraybi[i, 0]} - Nome:{arraybi[i, 1]}");
            }
        }
    }
}
