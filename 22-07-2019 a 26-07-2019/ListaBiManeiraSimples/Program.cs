using ListaBiManeiraSimples.Carrega;
using ListaBiManeiraSimples.Mostrar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimples {
    class Program {
        static void Main(string[] args) {
            
                //Aqui iniciamos nosso objeto em memoria
            var carregaLista = new CarregaLista();
                //Aqui chamamos o nosso metodo para carregar a lista
            //carregaLista.CarregaInformacoesEListaElasEmTela(listaDeNome);

            var MostraeLista = new MostrarLista();

            //MostrarLista.PesquisandoInformacoesNaNossaLista(listaDeNome, "0");


        }
    }
}
