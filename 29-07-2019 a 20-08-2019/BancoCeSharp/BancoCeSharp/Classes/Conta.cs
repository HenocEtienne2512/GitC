using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCeSharp.Classes {
   public class Conta {
        double saldo = 0;

        public double Saldo { get { return saldo; } }
        public Conta() {
            //Bonus de mil reais para iniciar a oprerar Daytrade
            saldo = 1000;
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="valor"></param>
       /// <returns></returns>
        public bool Sacar(double valor) {
            if (valor <= saldo) { // Desconta do valor em saldo na conta
                saldo -= valor;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Metodo para mostrar o saldo em conta disponivel
        /// </summary>
        public double mostrarSaldo() {
            Console.WriteLine($"Saldo em conta disponivel:{saldo.ToString("N2")}");
            return saldo;
        }
   }
}
