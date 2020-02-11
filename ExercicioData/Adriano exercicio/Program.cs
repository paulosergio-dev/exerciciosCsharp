using System;
using System.Globalization;

namespace exercicioDataAdriano15 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Primeira data (DD/MM/AAAA): ");
            DateTime dataInicial = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Segunda data (DD/MM/AAAA): ");
            var dataFinal = DateTime.Parse(Console.ReadLine());

            TimeSpan ts = dataFinal.Subtract(dataInicial);
            Console.WriteLine("Diferença em dias: " + ts.Days);

            var cultureAlemao = new CultureInfo("de-DE");
            
            for (DateTime dia = dataInicial.Date; dia <= dataFinal.Date; dia = dia.AddDays(1))
                {
                if(!(dia.DayOfWeek== DayOfWeek.Saturday || dia.DayOfWeek == DayOfWeek.Sunday)) 
                {
                    Console.WriteLine();
                    Console.WriteLine(dia.ToLongDateString());
                    Console.WriteLine(cultureAlemao.DateTimeFormat.GetDayName(dia.DayOfWeek) + " : " + dia);

                }
            }    
                                 
            Console.ReadLine();
        }
    }
}
