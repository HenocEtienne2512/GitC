using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecaOnline {
    class Program {
        static string[,] baseDeLivros;
        static void Main(string[] args) {

            CarregaBaseDeDados();
            MostrarSejaBemVindo();

            if (MenuInicial() == 1) {
                MostrarMenuAlacacao();
            }

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que mostra as informações iniciais do sistema.
        /// </summary>
        private static void MostrarSejaBemVindo() {
            Console.WriteLine("________________________________________");
            Console.WriteLine("    Sistema de locação  de Livros.");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("  Desenvolvido pelas Industrias Fhesseau");
            Console.WriteLine("----------------------------------------");
        }

        /// <summary>
        /// Metodo que mostra o conteudo do menu e as opções de escolha.
        /// </summary>
        /// <returns>Retorna o valaor do menu escolhido em um tipo inteiro</returns>
        public static int MenuInicial() {
            Console.WriteLine("\r\nMenu - Inicial");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1 - Alocar um livro");
            Console.WriteLine("2 - Sair do Sistema");
            Console.WriteLine("Digite a opção desejada:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }

        /// <summary>
        /// Carregar a base de dados dentro do sistema
        /// </summary>
        public static void CarregaBaseDeDados() {

            baseDeLivros = new string[2, 2] {
            { "O pequeno", "sim"},
            { "O grande", "não"}
            };
        }

        /// <summary>
        /// Metodo que retorna se o livro pode ser alocado
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser pesquisado</param>
        /// <returns>Retorna verdadeira em caso o livro estiver livre para alocação</returns>
        public static bool PesquisarLivroParaAlocacao(string nomeLivro) {

            for (int i = 0; i < baseDeLivros.GetLength(0); i++) {
                if (nomeLivro == baseDeLivros[i, 0]) {
                    Console.WriteLine($"o livro: {nomeLivro}" + $" pode ser alocado?:{baseDeLivros[i, 1]}");

                    return baseDeLivros[i, 1] == "sim";
                }
            }
            return false;
        }

        /// <summary>
        /// Metodo que aloca o livro de acordo com o parametro passado.
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser alocado</param>
        public static void AlocarLivro(string nomeLivro) {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++) {
                if (nomeLivro == baseDeLivros[i,0]) {
                    baseDeLivros[i, 1] = "não";
                }
            }
        }
        /// <summary>
        /// Metodo que carrega o conteudo inicial da aplicação do menu 1
        /// </summary>
        public static void MostrarMenuAlacacao() {
            Console.Clear();
            MostrarSejaBemVindo();
            Console.WriteLine("Menu - Alocação de Livros");
            Console.WriteLine("Digite o nome do livro a ser alocado:");

            var nomedolivro = Console.ReadLine();
            if (PesquisarLivroParaAlocacao(nomedolivro)) {

                Console.Clear();
                Console.WriteLine("Você deseja alocar o livro? para sim(1) para não(0)");

                if (Console.ReadKey().KeyChar.ToString() == "1") {
                    AlocarLivro(nomedolivro);
                    Console.Clear();
                    Console.WriteLine("Livro alocado com sucesso!!!");
                } else {
                    Console.Clear();
                }
                Console.WriteLine("Listagem de livros:");

                for (int i = 0; i < baseDeLivros.GetLength(0); i++) {
                    Console.WriteLine($"Nome: {baseDeLivros[i, 0]} Disponivel:{baseDeLivros[i, 1]}");

                }
            }
        }
    }
}
