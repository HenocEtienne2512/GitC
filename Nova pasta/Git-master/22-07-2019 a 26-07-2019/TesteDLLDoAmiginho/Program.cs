using CalculadoraQueCalculaCalculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDLLDoAmiginho {
    class Program {
        static void Main(string[] args) {
            CalculaPakas meusTestes = new CalculaPakas();

            Console.WriteLine($"O resultado da soma é : {meusTestes.Soma(5, 8)}");
            Console.ReadKey();
            Console.WriteLine("-----------------------------------\r\n");

            Console.WriteLine($"O resultado da substração é : {meusTestes.Subtrai(19, 8)}");
            Console.ReadKey();
            Console.WriteLine("-----------------------------------\r\n");

            Console.WriteLine($"O resultado da multiplcação é :{meusTestes.Multiplica(5, 8)}");
            Console.ReadKey();
            Console.WriteLine("-----------------------------------\r\n");

            Console.WriteLine($"O resultado da divisão é :{meusTestes.Divide(40, 8)}");
            Console.ReadKey();
            Console.WriteLine("-----------------------------------\r\n");

            Console.WriteLine($"O resultado do calculo da area do retangulo é :{meusTestes.AreaRetangulo(5, 10)}");
            Console.ReadKey();
            Console.WriteLine("-----------------------------------\r\n");

            Console.WriteLine($"O resultado do calculo da area do triangulo é :{meusTestes.AreaTriangulo(5, 8)}");
            Console.ReadKey();
            Console.WriteLine("-----------------------------------\r\n");

            Console.WriteLine($"O resultado do calculo do raio do circulo é: {meusTestes.RaioCirculo(74)}");
            Console.ReadKey();
            Console.WriteLine("-----------------------------------\r\n");

        }
    }
}
