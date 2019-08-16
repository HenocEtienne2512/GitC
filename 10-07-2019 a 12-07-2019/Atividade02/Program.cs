using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02 {
    class Program {
        static void Main(string[] args) {

           

            string[] ReceitaDeBolo = new string[6] 
                { "3 xícaras (chá) de farinha de trigo.",
                  "4 ovos",
                  "2 xícaras (chá) de açúcar.",
                    "2 colheres (sopa) de fermento.",
                    "1 xícara (chá) de leite.",
                  "4 colheres (sopa) de chocolate em pó" };

            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine("XXX------BEM VINDO AO HENOC PADARIA---------XXX");
            Console.WriteLine("XXX-----RECEITA DE BOLO DE CHOCOLATE--------XXX");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX\r\n" +
                "");

            Console.WriteLine("Apertar a tecla ENTER para visualizar a receita\r\n");


            for (int i = 0; i < ReceitaDeBolo.GetLength(0); i++) {
                Console.ReadKey();
                Console.WriteLine($"{i+1}º Ingrediente : {ReceitaDeBolo[i]}");
            }
           
        }
    }
}
