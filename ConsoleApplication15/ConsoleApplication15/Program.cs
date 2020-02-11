using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApplication15 {
    class Program {
        static void Main(string[] args) {


            double nota1, nota2, soma;

            Console.WriteLine("DIGITE PRIMEIRA NOTA");

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("DIGITE SEGUNDA NOTA");

            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = nota1 + nota2;

            Console.WriteLine("NOTA FINAL = " + soma.ToString("F1", CultureInfo.InvariantCulture));

            if (soma < 60.0) {
                Console.WriteLine("VOCÊ FOI REPROVADO");
            }


            Console.ReadLine();


        }
    }
}