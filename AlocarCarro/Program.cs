using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlocarCarro {
    class Program {
        static string[,] baseDosCarros;
        static void Main(string[] args) {
            MostrarBemVindos();

            //MenuPricipal();
            if (MenuPricipal() == 1) {
                MostrarMenuAlacacao();
            }
            
            Console.ReadKey();
        }
        public static void MostrarBemVindos() {
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine("XXX------BEM VINDO AO HENOC RENT-A-CAR------XXX");
            Console.WriteLine("XXX-------CARROS DE TODAS AS MARCAS---------XXX");
            Console.WriteLine("XXX----------E TODOS OS PREÇOS--------------XXX");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        }

        public static int MenuPricipal() {
            Console.WriteLine("\r\nMENU - PRICIPAL");
            Console.WriteLine("QualO que você deseja realizar:");
            Console.WriteLine("1 - Alocar um Carro");
            Console.WriteLine("2 - Sair do sistema");
            Console.WriteLine("Escolher a opção desejada");
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);
            return opcao;
        }

        public static void CarregaBaseCarros() {
            baseDosCarros = new string[2, 3] {
                { "Corola", "2018","Sim" },
                { "Gol", "2014", "Não" }
            };
        }

        public static bool PesquisarCarroParaAlocacao(string nomeCarro, int ano) {
            for (int i = 0; i < baseDosCarros.GetLength(0); i++) {
                if (nomeCarro == baseDosCarros[i, 0] && ano.ToString() == baseDosCarros[i,1]) {
                    Console.WriteLine($"carro: {nomeCarro}"+ $"ano: {ano}" + $" pode ser alocado?:{baseDosCarros[i, 2]}");

                    return baseDosCarros[i, 2] == "Sim";
                }
            }
            return false;
        }
        public static void AlocarCarro(string nomeLivro) {
            for (int i = 0; i < baseDosCarros.GetLength(0); i++) {
                if (nomeLivro == baseDosCarros[i, 1]) {
                    baseDosCarros[i, 1] = "Não";
                }
            }
        }

        public static void MostrarMenuAlacacao() {
            Console.Clear();
            MostrarBemVindos();

            Console.WriteLine("MENU - ALOCAÇÃO DE CARROS");
            Console.WriteLine("Digite o tipo de carro a ser alocado:");
            var nomedoCarro = Console.ReadLine();

            Console.WriteLine("Informe o ano correspondente ao carro:");
            String ano = Console.ReadLine();

            int.TryParse(ano, out int resultado);
            if (PesquisarCarroParaAlocacao(nomedoCarro, resultado)) {

                Console.Clear();

                Console.WriteLine("Você já fez sua escolha? para sim(1) para não(0)");

                if (Console.ReadKey().KeyChar.ToString() == "1") {
                    AlocarCarro(nomedoCarro);
                    Console.Clear();
                    Console.WriteLine("Carro alocado com sucesso!!!");
                } else {
                    Console.Clear();
                }
                Console.WriteLine("Listagem de Carro:");

                for (int i = 0; i < baseDosCarros.GetLength(0); i++) {
                    Console.WriteLine($"Nome: {baseDosCarros[i, 0]} Disponivel:{baseDosCarros[i, 2]}");

                }
            }
        }
    }
}
