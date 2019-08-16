using BancoCeSharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCeSharp {
    class Program {
        static void Main(string[] args) {
            Conta accountUser = new Conta();
            Console.WriteLine("Informe o valor para sacar:");
            double.TryParse(Console.ReadLine(), out double valorSacar);

            if (valorSacar > 0 && accountUser.Sacar(valorSacar)) {
                Console.WriteLine("Saque realizado com sucesso");

            } else {
                Console.WriteLine("Operação não realizada.");
            }
            //Mostrar o saldo disponivel
            Console.WriteLine($"saldo atual disponivel: {accountUser.mostrarSaldo()}");

            Console.ReadKey();
        }
    }
}
