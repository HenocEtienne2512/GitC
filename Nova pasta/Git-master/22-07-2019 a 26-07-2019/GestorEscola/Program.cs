using ProgBoletimEscolar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEscola {
    class Program {
        static void Main(string[] args) {

            RegistroAluno result = new RegistroAluno();
            result.carregaAluno();
            Console.Clear();

            result.ListarAluno();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Informe o registro que deseja alterar:");
            int.TryParse(Console.ReadLine(), out int reg);
            result.AlteraNotas(reg);
            Console.Clear();

            result.ListarAluno();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Informe o registro que deseja excluir:");
            int.TryParse(Console.ReadLine(), out reg);
            result.ExcluirLista(reg);
        
            Console.Clear();
            result.ListarAluno();

            Console.ReadKey();
        }
    }
}
