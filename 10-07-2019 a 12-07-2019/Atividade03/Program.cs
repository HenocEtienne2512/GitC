using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade03 {
    class Program {
        static string[,] ListaDeNomes;
        static void Main(string[] args) {
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine("XXX---------LISTA DE NOMES DA SALA----------XXX");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX\r\n");

            Console.WriteLine("  Teclar ENTER para exibir a lista de nomes");
            Console.WriteLine("______________________________________________\r\n");
            Console.ReadKey();

            CarregaNomes();
        }
        public static void CarregaNomes() {
            ListaDeNomes = new string[20, 3] {
                { "Henoc", "37", "M" },
                { "Alex H", "29", "M" },
                { "Falande", "30", "F" },
                { "Leandro", "19", "M" },
                { "João A", "25", "M" },
                { "Jean A", "20", "M" },
                { "Moises", "14", "M" },
                { "Woodly", "17", "M" },
                { "Marie", "35", "F" },
                { "Juliano", "21", "M" },
                { "Lucas", "31", "M" },
                { "Patrice", "70", "M" },
                { "Stephania", "30", "M" },
                { "Etienne", "28", "F" },
                { "Loiseau", "16", "F" },
                { "Pierre", "18", "M" },
                { "Luis", "28", "M" },
                { "Bertrand", "25", "M" },
                { "Samuel", "31", "M" },
                { "Webster", "34", "M" }
            };
            for (int i = 0; i < ListaDeNomes.GetLength(0); i++) {
                Console.WriteLine($"{i+1}º nome : {ListaDeNomes[i,0]} \tidade: {ListaDeNomes[i,1]} \tsexo: {ListaDeNomes[i,2]}");
            }
            Console.ReadKey();
        }
    }
}
