using MinhaPrimeiraListaTipada.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraListaTipada {
    class Program {
        static void Main(string[] args) {
            //O indicador <T> o tipo da minha lista com isso temos uma lista de lanches
            List<Lanche> minhaLista = new List<Lanche>();

            for (int i = 0; i < 5; i++) {
                minhaLista.Add(new Lanche() {
                    Nome = Console.ReadLine(),
                    Quantidade = int.Parse(Console.ReadLine()),
                    Valor = double.Parse(Console.ReadLine())
                });
            }
           
            foreach (Lanche item in minhaLista) {
                Console.WriteLine($"Lanches disponiveis: {item.Nome}");
            }
            Console.WriteLine("Removendo item...");
            foreach (Lanche item in minhaLista) {
                if (item.Quantidade == 3) {
                    minhaLista.Remove(item);
                    break;
                }
            }
            /*
            minhaLista.Remove(minhaLista.FirstOrDefault(x => x.Quantidade == 2));
            var meniItem = (from item in minhaLista
                            where item.Quantidade == 3
                            select item).ToList<Lanche>();
            */
            foreach (Lanche item in minhaLista) {
                Console.WriteLine($"Lanches disponiveis: {item.Nome}");
            }
            Console.ReadKey();
        }
    }
}
