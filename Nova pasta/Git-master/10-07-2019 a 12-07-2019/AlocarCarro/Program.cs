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

            while (opcaoMenu != 4) {
                if (opcaoMenu == 1)
                    AlocarUmCarro();

                if (opcaoMenu == 2)
                    DesalocarUmCarro();

                if (opcaoMenu == 3)
                    MostrarListaDeCarros();
                    Console.ReadLine();

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
            Console.WriteLine("3 - Verificar disponiblidade do carro.");
            Console.WriteLine("4 - Sair do sistema");
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

        public static bool? PesquisarCarroParaAlocacao(ref string nomeCarro, int ano) {
            for (int i = 0; i < baseDosCarros.GetLength(0); i++) {
                if (CompararNomes(nomeCarro, baseDosCarros[i, 0]) && ano.ToString() == baseDosCarros[i,1]) {
                    Console.WriteLine($"carro: {nomeCarro}"+ $"ano: {ano}" + $" pode ser alocado?:{baseDosCarros[i, 2]}");

                    return baseDosCarros[i, 2] == "Sim";
                }
            }
            Console.WriteLine("Nenhum carro encontrado. Deseja realizar a busca novamente ?");
            Console.WriteLine("Digite o número da opção desejada: sim(1) não(0)");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            if (opcao == 1) {
                Console.WriteLine("Digite o tipo de carro a ser pesquisado:");
                nomeCarro = Console.ReadLine();

                return PesquisarCarroParaAlocacao(ref nomeCarro, ano);
            }

            return null;
        }
    
        public static void AlocarCarro(string nomeCarro, bool alocar) {
            for (int i = 0; i < baseDosCarros.GetLength(0); i++) {
                if (CompararNomes(nomeCarro,  baseDosCarros[i, 0])) {
                    baseDosCarros[i, 2] = alocar ? "não" : "sim"; 
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
            var resultadoPesquisa = PesquisarCarroParaAlocacao(ref nomedoCarro, resultado);

            if (resultadoPesquisa != null && resultadoPesquisa == true) {
                Console.Clear();
                MostrarBemVindos();
                Console.WriteLine("Você deseja alugar o carro? para sim(1) para não(0)");

                AlocarCarro(nomedoCarro, Console.ReadKey().KeyChar.ToString() == "1");

                MostrarListaDeCarros();

                Console.ReadKey();
            }
            if (resultadoPesquisa == null) {
                Console.WriteLine("Nenhum carro deste tipo foi encontrado em nossa base de dados do sistema.");
            }
        }
       
        public static void MostrarListaDeCarros() {
            Console.WriteLine("\r\nListagem de Carros:");

            for (int i = 0; i < baseDosCarros.GetLength(0); i++) {
                Console.WriteLine($"Nome: {baseDosCarros[i, 0]} ano: {baseDosCarros[i, 1]} Disponivel:{baseDosCarros[i, 2]}");
            }
        }

        public static void DesalocarUmCarro() {
            MostrarMenuInicialCarros("Desalocar um Carro:");
            Console.WriteLine("Digite o tipo de carro para desalocar:");
            var nomedoCarro = Console.ReadLine();

            Console.WriteLine("Informe o ano correspondente ao carro:");
            String ano = Console.ReadLine();

            MostrarListaDeCarros();

            int.TryParse(ano, out int resultado);

            var resultadoPesquisa = PesquisarCarroParaAlocacao(ref nomedoCarro, resultado);

            if (resultadoPesquisa != null && resultadoPesquisa == false) {
                Console.Clear();
                MostrarBemVindos();
                Console.WriteLine("Você deseja desalocar o Carro? para sim(1) para não(0)");

                AlocarCarro(nomedoCarro, Console.ReadKey().KeyChar.ToString() == "0");

                MostrarListaDeCarros();

                Console.ReadKey();
            }
            if (resultadoPesquisa == null) {
                Console.WriteLine("Nenhum carro deste tipo foi encontrado em nossa base de dados do sistema.");
            }
        }

        public static void MostrarMenuInicialCarros(string operacao) 
        {
            Console.Clear();

            MostrarBemVindos();

            Console.WriteLine($"MENU - ALOCAÇÃO DE CARROS - operação: {operacao}");

        }

        public static bool CompararNomes(string informacaoParaComparar, string informacaoASerComparada) {
            if (informacaoParaComparar.ToLower().Replace(" ", "")
                    == informacaoASerComparada.ToLower().Replace(" ", ""))
                return true;

            return false;
        }

    }

}

