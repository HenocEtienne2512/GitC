using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01 {
    class Program {
        static void Main(string[] args) {
           
            Console.WriteLine("Informe o seu nome:");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe a sua idade:");
            var idade = int.Parse(Console.ReadLine());

            if (idade  >=  18) {
                Console.WriteLine("Você está autorizado(a) a consumir bebidas alcoólicas");
            } else {
                Console.WriteLine("Você não está autorizado(a) a consumir bebidas alcoólicas");
            }
            Console.ReadKey();
        }
    }
}

