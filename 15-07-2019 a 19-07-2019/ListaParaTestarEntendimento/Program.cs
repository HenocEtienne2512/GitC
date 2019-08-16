using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaParaTestarEntendimento {
    class Program {
        static void Main(string[] args) {
            string[,] ListaDeAluno = new string[2, 3];
            int matricula = 0;

            InserirRegistro(ref ListaDeAluno, ref matricula);

            Console.ReadKey();
        }

        public static void InserirRegistro(ref string[,] ListaDeAluno, ref int matricula) {
            for (int i = 0; i < ListaDeAluno.GetLength(0); i++) {

                if (ListaDeAluno[i, 0] != null) {
                    continue;
                }

                Console.WriteLine("Informe o nome do aluno:");
                var nome = Console.ReadLine();
                ListaDeAluno[i, 1] = nome;

                Console.WriteLine("Informe a turma:");
                var turma = Console.ReadLine();
                ListaDeAluno[i, 2] = turma;

                ListaDeAluno[i, 0] = (matricula++).ToString();

                Console.WriteLine("Deseja inserir um novo registro? sim(1) ou não(0)");
                var continuar = Console.ReadKey().KeyChar.ToString();

                if (continuar == "0")
                    break;

            }
            Console.WriteLine("Registro adicionados com sucesso, segue lista de informações adicionadas:");

            for (int i = 0; i < ListaDeAluno.GetLength(0); i++) {

                Console.WriteLine(string.Format("Registro da Matricula {0} - Nome do Aluno:{1} - turma:{2}", ListaDeAluno[i, 0], ListaDeAluno[i, 1], ListaDeAluno[i, 2]));
            }
        }

        public static void AumentaLista(ref string[,] ListaDeAluno) {
            var limitaLista = true;

            for (int i = 0; i < ListaDeAluno.GetLength(0); i++) {
                if (ListaDeAluno[i, 0] == null) 
                    limitaLista = false;

                
                if (limitaLista) { 
                    var listaCopia = ListaDeAluno;
                    ListaDeAluno = new string[ListaDeAluno.GetLength(0) + 5, 2];

                    for (int i = 0; i < listaCopia.GetLength(0); i++) {
                        ListaDeAluno[i, 0] = listaCopia[i, 0];
                        ListaDeAluno[i, 1] = listaCopia[i, 1];
                    }
                   
                    Console.WriteLine("O tamanho da lista foi atualizado.");
                }
            }

        }
    }

}