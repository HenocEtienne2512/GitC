using CriacaoDeListaOrganizada.CriacaoDeLista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeListaOrganizada {
    class Program {
        static void Main(string[] args) {
            //var lista = new Lista();

            ListaOrg obj = new ListaOrg();
            obj.CarregaLista();
            obj.Listar();
            obj.LimpaLista();
            obj.Listar();

            Console.ReadKey();
        }
    }
}
