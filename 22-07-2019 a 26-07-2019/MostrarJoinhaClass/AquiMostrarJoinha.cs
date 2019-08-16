using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarJoinhaClass
{
    public class AquiMostrarJoinha
    {
        /// <summary>
        /// será que hoje é sexta
        /// </summary>
        /// <returns></returns>
        public void MetodoInicialDojoinha() {
            Console.WriteLine("Aqui iniciamos o nosso joinha.");

            Console.ReadKey();
        }
        /// <summary>
        /// Aqui ainda não bebe mais que eu!!!!
        /// </summary>
        /// <param name="eQuinta">2.0 ainda fez 3 por 1</param>
        public void MetodoDoisPontoZero(bool eQuinta) {
            if (eQuinta) {
                Console.WriteLine("Cariai mermão");
            } else { 
                Console.WriteLine("Aiaiaiaiaiaiaaaiiii");
            }
            Console.ReadKey();
        }

        public string[] TesteUmOperadorLegal() {
            return new string[2] { "Teste1", "Teste2" };
        }
    }
}
