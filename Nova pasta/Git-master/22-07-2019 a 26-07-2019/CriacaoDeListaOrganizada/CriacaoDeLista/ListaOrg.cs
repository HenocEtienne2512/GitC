using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeListaOrganizada.CriacaoDeLista {
    class ListaOrg {
        string[] lista;
        public  void CarregaLista() {
            lista = new string[10];

            for (int i = 0; i < lista.Length; i++) {
                
                lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");  
            }
        }

        public void LimpaLista() {
            Console.WriteLine("Limpando itens... ");
            for (int i = 0; i < lista.Length; i++)
                lista[i] = string.Empty;
        }
        public void Listar() {
            Console.WriteLine("Listando itens...");
            foreach (var item in lista)

           Console.WriteLine(item);
        }

    }
}
