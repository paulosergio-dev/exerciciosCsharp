using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14 {
    class Program {
        static void Main(string[] args) {

            int horas;

            Console.Write("Quantas horas ? ");
            horas = int.Parse(Console.ReadLine());

            if (horas < 12) {
                Console.WriteLine("bom dia!");
            }
            else {
                if (horas < 18) {
                    Console.WriteLine("Boa tarde!");
                }
                else {
                    Console.WriteLine("Boa noite!");
                }
            }


            Console.ReadLine();
        }
    }
}
