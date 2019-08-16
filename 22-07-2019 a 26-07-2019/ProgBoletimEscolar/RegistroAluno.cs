using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgBoletimEscolar {
    public class RegistroAluno {

        string[,] lista = new string[5, 5];


        Resultado result = new Resultado();
        public void carregaAluno() {

            for (int i = 0; i < lista.GetLength(0); i++) {
                Console.WriteLine("Informe o nome do aluno");

                var nome = Console.ReadLine();
                lista[i, 0] = i.ToString();
                lista[i, 1] = nome;

                Console.WriteLine($"Informe a primeira nota:");
                Double nota1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Informe a segundaa nota:");
                Double nota2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Informe a terceira nota:");
                Double nota3 = Convert.ToDouble(Console.ReadLine());

                var media = result.CalcularMedia(nota1, nota2, nota3);
                lista[i, 2] = media.ToString("F");

                Console.WriteLine($"Informe a quantidade de aulas:");
                int QtdAula = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Informe a quantidade de faltas:");
                int QtFalta = Convert.ToInt32(Console.ReadLine());

                var frequencia = result.CalcularFrequencia(QtdAula, QtFalta);
                lista[i, 3] = frequencia.ToString();

                lista[i, 4] = result.ResultBoletim(media, frequencia);

                Console.WriteLine($"O aluno {lista[i, 1]} é {lista[i, 4]} \r\n" +
                    $" com a média: {lista[i, 2]}\r\n" +
                    $" de frequencia: {lista[i, 3]} %");
            }
        }
        public void ListarAluno() {
            for (int i = 0; i < lista.GetLength(0); i++) {
                if (lista[i, 1] == "") {
                    continue;
                }
                Console.WriteLine($"ID{lista[i, 0]}. O aluno {lista[i, 1]} é {lista[i, 4]} com a média: {lista[i, 2]} de frequencia: {lista[i, 3]} %");
            }
        }

        public void ExcluirLista(int Id) {
            for (int i = 0; i < lista.GetLength(0); i++) {
                if (lista[i, 0] == Id.ToString()) {

                    lista[i, 1] = "";
                    lista[i, 2] = "";
                    lista[i, 3] = "";
                    lista[i, 4] = "";
                }
            }
        }
        public double RedigitaNotas() {

            Console.WriteLine($"Informe a primeira nota:");
            Double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Informe a segundaa nota:");
            Double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Informe a terceira nota:");
            Double nota3 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine($"Informe a quantidade de aulas:");
            int QtdAula = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Informe a quantidade de faltas:");
            int QtFalta = Convert.ToInt32(Console.ReadLine());

            var frequencia = result.CalcularFrequencia(QtdAula, QtFalta);
           

            return result.CalcularMedia(nota1, nota2, nota3);
        }

        public void AlteraNotas(int Id) {
            for (int i = 0; i < lista.GetLength(0); i++) {
                if (lista[i, 0] == Id.ToString()) {

                    var media = RedigitaNotas();
                    lista[i, 2] = media.ToString();

                    var frequencia = Convert.ToInt32(lista[i, 3]);
                    lista[i, 4] = result.ResultBoletim(media, frequencia);
                }
            }
        }
    }
}
