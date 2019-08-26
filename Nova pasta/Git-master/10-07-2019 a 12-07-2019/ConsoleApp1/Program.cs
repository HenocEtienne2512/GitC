using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            string[] nameList = new string[2] { "valor1", "valor2" };

            foreach (var item in nameList)
                Console.WriteLine(item);

            //string[] dateList = new string[10];
            string[] dateList = new string[10000];

            DateTime firstTime = DateTime.Now;

            for (int i = 0; i < dateList.Length; i++) {
                //dateList[i] = DateTime.Now.ToString("yyyyMMddhhmmssfff");
                dateList[i] = DateTime.Now.ToString("hh:mm:ss.fff");
                Console.WriteLine(dateList[i]);
                // Thread.Sleep(1000);
            }
            Console.WriteLine((DateTime.Now - firstTime).ToString());
           
            /*
            foreach (var item in dateList)
                Console.WriteLine(item);
                */
            Console.ReadKey();
        }
    }
}
