using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalConsole {
    class Program {
        static void Main(string[] args) {
            string[,] baseDDLivros = new string[2, 5];
           

            int IndiceBDLivros = 0;

            var escolhaInicial = MainMenu();
            
            while (true) {
                
                switch (escolhaInicial) {
                    case "1": {InsertIntoList(ref baseDDLivros, ref IndiceBDLivros); } break;
                    case "2": {RemoveIntoList(ref baseDDLivros); } break;
                    case "3": {ShowInformation(baseDDLivros);} break;
                    case "4": {ShowInformation(baseDDLivros,"true");} break; 
                    case "5": {
                            return;
                        }
                }
                //Alimento a escolha novamente 
                escolhaInicial = MainMenu();
            }
        }
        /// <summary>
        /// Mostra as informações iniciais do sistema.
        /// </summary>
        public static void MostrarSejaBemVindo() {
            Console.WriteLine("*************************************************");
            Console.WriteLine("         SISTEMA DE ALOCAÇÃO DE LIVROS.");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("         DESENVOLVIDO PELO HENOC_SIS");
            Console.WriteLine("_________________________________________________");
        }
        /// <summary>
        /// Metodo que mostra o menu principal com as opções para escolha.
        /// </summary>
        /// <returns>Retorna o número da opção escolhida.</returns>
        public static string MainMenu() {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine("Iniciando a liste de registração de livros\r\n");

            Console.WriteLine("    MENU PRICIPAL");
            Console.WriteLine("1 - Inseir um novo registro.");
            Console.WriteLine("2 - Remover um novo registro.");
            Console.WriteLine("3 - Listar informações.");
            Console.WriteLine("4 - Lista as informações desativadas.");
            Console.WriteLine("5 - Sair do sistema.");

            Console.WriteLine("Digite o número da opção desejada:");



            return Console.ReadLine();
        }
        /// <summary>
        /// Metodo que insere informações dentro da nossa base de dados
        /// </summary>
        /// <param name="baseDDLivros">Basse de dados como ref para alterar para todos os metodos</param>
        /// <param name="indiceBase">Indice da nossa base como red para alterar para todos os metodos</param>
        public static void InsertIntoList(ref string[,] baseDDLivros, ref int indiceBase) {
            Console.WriteLine("---------Inserindo valores na lista---------");

            Console.WriteLine("Informe o nome do livro:");
           
            var nomeDoLivro = Console.ReadLine();

            Console.WriteLine("Informe o nome do Autor");
           
            var autor = Console.ReadLine();


            UpSizeList(ref baseDDLivros);

            
            for (int i = 0; i < baseDDLivros.GetLength(0); i++) {
                if (baseDDLivros[i, 0] != null)
                    continue;
                
                baseDDLivros[i, 0] = (indiceBase++).ToString();
                baseDDLivros[i, 1] = nomeDoLivro;
                baseDDLivros[i, 2] = autor;
                baseDDLivros[i, 3] = "true";
                baseDDLivros[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                
                break;
            }
            
            Console.WriteLine("Registro cadastrado com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial, basta apertar qualquer tecla.");
            Console.ReadKey();

        }
        /// <summary>
        /// Metodo que aumenta as informações disponivel para cadastro dentro da nossa lista
        /// </summary>
        /// <param name="baseDDLivros"></param>
        public static void UpSizeList(ref string[,] baseDDLivros) {
            var limiteDaLista = true;
           
            for (int i = 0; i < baseDDLivros.GetLength(0); i++) {
               
                if (baseDDLivros[i, 0] == null)
                    limiteDaLista = false;
            }

            
            if (limiteDaLista) { 
                var listaCopia = baseDDLivros;

                baseDDLivros = new string[baseDDLivros.GetLength(0) + 5, 5];
                for (int i = 0; i < listaCopia.GetLength(0); i++) {

                    baseDDLivros[i, 0] = listaCopia[i, 0];
                    baseDDLivros[i, 1] = listaCopia[i, 1];
                    baseDDLivros[i, 2] = listaCopia[i, 2];
                    baseDDLivros[i, 3] = listaCopia[i, 3];
                    baseDDLivros[i, 4] = listaCopia[i, 4];
                }
                Console.WriteLine("O tamanho da lista foi atualizado.");
            }

        }
        /// <summary>
        /// Metodo utilizado para remover um registro pelo id dentro do sistema
        /// </summary>
        /// <param name="baseDDLivros"></param>
        public static void RemoveIntoList(ref string[,] baseDDLivros) {
           
            Console.WriteLine("Area de remoção de registro do sistema.");
            
            for (int i = 0; i < baseDDLivros.GetLength(0); i++) {
                
                if (baseDDLivros[i, 3] != "false")
                    Console.WriteLine($"ID:{baseDDLivros[i, 0]} " +
                          $"- Nome do livro:{baseDDLivros[i, 1]} " +
                          $"- Nome do Autor:{baseDDLivros[i, 2]}");
            }
           
            Console.WriteLine("Informe o id do registro a ser removido:");
            var id = Console.ReadLine();
           
            for (int i = 0; i < baseDDLivros.GetLength(0); i++) {   
               
                if (baseDDLivros[i, 0] != null && baseDDLivros[i, 0] == id) {  
                    baseDDLivros[i, 3] = "false";
                    baseDDLivros[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                }
            }
           
            Console.WriteLine("Operações finalizadas.");
            Console.WriteLine("Para retornar ao menu principal apertar qualquer tecla.");
            Console.ReadKey();
        }
        /// <summary>
        ///  Exibir as informações dentro da nossa lista de dados"base de dados.
        /// </summary>
        /// <param name="baseDDLivros">base de dados para a leitura e mostrar pro usuario</param>
        /// <param name="RegistrosInativosShow">Quando identificado com o valor true, o mesmo
        /// mostra os valores que não estão ativos dentro do sistema</param>
        public static void ShowInformation(string[,] baseDDLivros, string RegistrosInativosShow = "false") {
            
            Console.WriteLine("Apresentação das informações dentro da base de dados.");
           
            if (RegistrosInativosShow == "true")
                Console.WriteLine("Registros desativados dentro do sistema.");
           
            for (int i = 0; i < baseDDLivros.GetLength(0); i++) {
               
                if (baseDDLivros[i, 3] != RegistrosInativosShow)
                    Console.WriteLine($"ID {baseDDLivros[i, 0]} " +
                          $"- Nome do Livro:{baseDDLivros[i, 1]} " +
                          $"- Nome do Autor:{baseDDLivros[i, 2]}" +
                          $"- Data Alteração:{baseDDLivros[i, 4]}");
            }
            Console.WriteLine("Resultados apresentados com sucesso!");
            Console.WriteLine("Para retornar ao menu principal apertar qualquer tecla.");
            Console.ReadKey();
        }

    }
}
