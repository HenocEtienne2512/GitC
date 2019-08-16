using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculadora {
    public class Calcuradora {
        public int Somar(int valor1, int valor2) {
            return valor1 + valor2;
        }

        public int Subtrair(int valor1, int valor2) {
            return valor1 - valor2;
        }
        public double Multiplicar(int valor1, int valor2) {
            return valor1 * valor2;
        }

        public double Dividir(int valor1, int valor2) {
            return valor1 / valor2;
        }

        public double CalcAreaRetandulo(int base1, int altura2) {
            return base1 * altura2;
        }

        public double CalcAreaTriEquilatero(int base1, int altura2) {
            return (base1 / altura2) / 2;
        }

        public double CalcRaioCirculo(double area) {
            var raio = Math.Sqrt(area/3.14);
            return raio;
        }

    }
}
