using Listar_meus_carros.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listar_meus_carros {
    class Program {
        static void Main(string[] args) {
            List<ListaDeCarros> ListaCarros = new List<ListaDeCarros>();
            var Lista = 3;
            MostrarMenu();
            int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o modelo, marca e o ano do carro");
            for (int i = 0; i < Lista; i++) {
                ListaCarros.Add(new ListaDeCarros() {
                    Modelo = Console.ReadLine(),
                    Marca = Console.ReadLine(),
                    Ano = int.Parse(Console.ReadLine())
                });
                foreach (ListaDeCarros item in ListaCarros) {
                    Console.WriteLine($"Modelo: {item.Modelo} marca: {item.Marca} ano : {item.Ano}");

                }
            } 
            Console.ReadKey();
        }
        public static void MostrarMenu() {
            Console.Clear();
            Console.WriteLine("***MENU DE OPÇÕES***" +
                "\r\n 1 - Adicionar veiculo" +
                "\r\n 2 - Listar os Carros" +
                "\r\n Escolha uma opção listada:");
        }
        
    }
}
