using ClasseCantinaGG.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseCantinaGG {
    class Program {
        static void Main(string[] args) {
            Conta contaAluno = new Conta();
            Console.WriteLine("Escolha o lanche para comprar no MENU:");
            var opcao = contaAluno.MenuCantina();
            
            contaAluno.FazerCompra(opcao);
            Console.WriteLine($"O saldo disponivel é: {contaAluno.Saldo}");

            Console.ReadKey();
        }
    }
}
