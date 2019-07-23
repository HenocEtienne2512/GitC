using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators {
    class Program {
        static void Main(string[] args) {

            var elementoX = new Teste(5,5); 

            elementoX.MostrarInformacoes();

            elementoX.AlterarInformacoes(5, 5);

            elementoX.MostrarInformacoes();

            MeninaSuperFoderoza(elementoX);

            elementoX.MostrarInformacoes();

            Console.ReadKey();
        }
    }
    public static void MeninaSuperFoderoza(Teste pTeste) {
        pTeste.AlterarInformacoes();
        pTeste.MostrarInformacoes();
    }
    public class Teste {
        public int A { get; set; } = 0;
        public int B { get; set; } = 0;
        public Teste(int pA, int pB) {
            A = pA;
            B = pB;

        }
        public void AlterarInformacoes() {
            A = B * 2;
            
        }
        public void AlterarInformacoes(int pA, int pB) {
            A = pA * 2;
            B = pB * 2;
        }
        public void MostrarInformacoes() {

            Console.WriteLine(A + B);
        }
    }

}
