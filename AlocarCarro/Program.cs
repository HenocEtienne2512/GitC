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

            CarregaBaseCarros();

            var opcaoMenu = MenuPrincipal();

            while (opcaoMenu != 3) {
                if (opcaoMenu == 1)
                    AlocarUmCarro();

                if (opcaoMenu == 2)
                    DesalocarUmCarro();

                opcaoMenu = MenuPrincipal();
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

        public static int MenuPrincipal() {
            Console.WriteLine("\r\nMENU - PRICIPAL");
            Console.WriteLine("O que você deseja realizar:");
            Console.WriteLine("1 - Alocar um Carro");
            Console.WriteLine("2 - Devolver o carro.");
            Console.WriteLine("3 - Sair do sistema");
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
        public static void AlocarCarro(string nomeCarro, bool alocar) {
            for (int i = 0; i < baseDosCarros.GetLength(0); i++) {
                if (nomeCarro == baseDosCarros[i, 0]) {
                    baseDosCarros[i, 1] = alocar ? "não" : "sim"; 
                }
            }
            Console.Clear();
            MostrarBemVindos();
            Console.WriteLine("Carro atualizado com sucesso!");
        }

        public static void AlocarUmCarro() {
            MostrarMenuInicialCarros("Alocar um Carro:");
            Console.WriteLine("Digite o tipo de carro para alocar:");

            var nomedoCarro = Console.ReadLine();

            Console.WriteLine("Informe o ano correspondente ao carro:");
            String ano = Console.ReadLine();


            int.TryParse(ano, out int resultado);
            if (PesquisarCarroParaAlocacao(nomedoCarro, resultado)) {
                Console.Clear();
                MostrarBemVindos();
                Console.WriteLine("Você deseja alugar o carro? para sim(1) para não(0)");

                AlocarCarro(nomedoCarro, Console.ReadKey().KeyChar.ToString() == "1");

                MostrarListaDeCarros();

                Console.ReadKey();
            }
        }
       
        public static void MostrarListaDeCarros() {
            Console.WriteLine("Listagem de Carros:");

            for (int i = 0; i < baseDosCarros.GetLength(0); i++) {
                Console.WriteLine($"Nome: {baseDosCarros[i, 0]} Disponivel:{baseDosCarros[i, 2]}");
            }
        }

        public static void DesalocarUmCarro() {
            MostrarMenuInicialCarros("Desalocar um Carro:");
            Console.WriteLine("Digite o tipo de carro para desalocar:");
            var nomedoCarro = Console.ReadLine();

            Console.WriteLine("Informe o ano correspondente ao carro:");
            String ano = Console.ReadLine();

            MostrarListaDeCarros();

           // var nomedoCarro = Console.ReadLine();
           // String ano = Console.ReadLine();

            int.TryParse(ano, out int resultado);
            if (!PesquisarCarroParaAlocacao(nomedoCarro, resultado)) {
                Console.Clear();
                MostrarBemVindos();
                Console.WriteLine("Você deseja desalocar o Carro? para sim(1) para não(0)");

                AlocarCarro(nomedoCarro, Console.ReadKey().KeyChar.ToString() == "0");

                MostrarListaDeCarros();

                Console.ReadKey();
            }
        }

        public static void MostrarMenuInicialCarros(string operacao) 
        {
            Console.Clear();

            MostrarBemVindos();

            Console.WriteLine($"MENU - ALOCAÇÃO DE CARROS - operação: {operacao}");

        }

    }
}
