using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseCantinaGG.Classes {
    public class Conta {
        double saldo = 20;

        public double Saldo { get { return saldo; } }

        public bool SubstrairSaldo(double valor) {
            if (valor <= saldo) {
                saldo -= valor;
                return true;
            }
            return false;
        }
        public int MenuCantina() {
            Console.WriteLine("****MENU DA CANTINA******");
            Console.WriteLine("1- Pastel        R$ 3.00");
            Console.WriteLine("2- Croxinha      R$ 4.00");
            Console.WriteLine("3- Salgadinho    R$ 2.50");
            Console.WriteLine("4- Sair do MENU");
            int.TryParse(Console.ReadLine(), out int opcao);

            return opcao;
        }
         public double FazerCompra(int opcao) {
            if (opcao == 1) {
                SubstrairSaldo(3);
            } else
                if (opcao == 2) {
                SubstrairSaldo(4);
            } else
                if (opcao == 3) {
                SubstrairSaldo(2.50);
                }           
            return saldo;
         }
    }
}
