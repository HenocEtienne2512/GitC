using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] livros = new string[2, 2] {
                {"O pequeno", //Nome do Livro
                "sim"}, //Disponivel
                {"O grande", //Nome do Livro
                    "Não" //Disponivel
                } };
            Console.ReadKey();
            }
        }

    }
}
#region comentarios
//var count = 0;
//while(count < 10)
//{
//    Console.WriteLine("Teste");
//    count++;
//}
//int[] teste = new int[5] {99,1,2,3,4};
//for (int i = 0; i < teste.Length; i++)
//{
//    teste[i] = i;
//}
//for (int i = 0; i < teste.Length; i++)
//{
//    Console.WriteLine(teste[i]);
//}

//string[] listaDeNomes = new string[10];
//for(int i = 0; i < listaDeNomes.Length; i++)
//{
//    Console.WriteLine("Coloque o nome:");
//    listaDeNomes[i] = Console.ReadLine();
//    Console.Clear();
//}
//for (int i = 0; i < listaDeNomes.Length; i++)
//{
//    Console.WriteLine($"Nome cadastrado: {listaDeNomes[i]}");
//}

#endregion comentraios

#region Exercicio de Hoje
/*  string[] arrayStringContent = new string[2];
  int[] idade = new int[2];
  for (int i = 0; i < arrayStringContent.Length; i++)
  {
      Console.WriteLine("Coloque o nome:"); 

      arrayStringContent[i] = Console.ReadLine();
      Console.Clear();
  }
  for (int i = 0; i < idade.Length; i++)
  {
      Console.WriteLine("Informe a idade:");

      arrayStringContent[i] += "   de idade : " + Console.ReadLine() + " anos";
      Console.Clear();
  }
  for (int i = 0; i < arrayStringContent.Length; i++)
  {
      Console.WriteLine($"Nome cadastrado: {arrayStringContent[i]}");

  }*/
#endregion

#region Exercicio correção
/*
string[] stringListInfo = new string[1];
for(int i = 0; i < stringListInfo.Length; i++) {

   stringListInfo[i] = 
        $"Nome: {IsValid("", "Nome")}" +
        $" de idade: {IsNumberFormat(IsValid("", "Idade"),"00") +" anos"}" +
        $" e pesa: {IsNumberFormat(IsValid("", "Peso"),"N2") + " Kg"} \r\n";
}
Console.Clear();
for (int i = 0; i < stringListInfo.Length; i++) {
   Console.WriteLine(stringListInfo[i]);             
}
Console.ReadKey();
}
public static string IsValid( string value,string fieldname) {
var retorno = value;

while (string.IsNullOrEmpty(retorno) || string.IsNullOrWhiteSpace(retorno)) {
    Console.Clear();
    Console.WriteLine($"Informe um valor para o campo {fieldname} :");
    retorno = Console.ReadLine();
}
return retorno;
}
private static string IsNumberFormat(object values, string format) {
int.TryParse(values.ToString(), out int retorno);
return retorno.ToString(format);
*/
#endregion
