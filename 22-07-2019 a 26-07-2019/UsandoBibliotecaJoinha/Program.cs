using MostrarJoinhaClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoBibliotecaJoinha {
    class Program {
        static void Main(string[] args) {
            /*
            new AquiMostrarJoinha().MetodoInicialDojoinha();

            new AquiMostrarJoinha().MetodoDoisPontoZero(true);

            new AquiMostrarJoinha().MetodoDoisPontoZero(false);

            Console.WriteLine(new AquiMostrarJoinha().TesteUmOperadorLegal());
            */

            // operação pesada como leitura e gravação na memoria
            var outroCaraParaRealizarOTeste = new AquiMostrarJoinha().TesteUmOperadorLegal();

            //Contagem de todos os registros da nossa lista
            var tamanhoDaLista = outroCaraParaRealizarOTeste.Length;

            //Nosso for agora esta mais rapido
            for (int i = 0; i < tamanhoDaLista; i++) {
                Console.WriteLine(outroCaraParaRealizarOTeste[i]);
            }

            Console.ReadKey();
        }
    }
}
