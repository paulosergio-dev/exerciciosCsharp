using System;
using System.Globalization;

namespace ExercicioDateTime
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data inicial (dd/MM/aaaa): ");
            DateTime dataInicial = DateTime
                .ParseExact(Console.ReadLine(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture);

            Console.WriteLine("Data final (dd/MM/aaaa): ");
            DateTime dataFinal = DateTime
               .ParseExact(Console.ReadLine(),
               "dd/MM/yyyy",
               CultureInfo.InvariantCulture);

            TimeSpan ts = dataFinal.Subtract(dataInicial);
            Console.WriteLine("Diferença em dias: " + ts.Days);


            var cultureAlemao = new CultureInfo("de-DE");

            for (DateTime dia = dataInicial.Date; dia <= dataFinal.Date; dia = dia.AddDays(1))
            {
                if (!(dia.DayOfWeek == DayOfWeek.Saturday || dia.DayOfWeek == DayOfWeek.Sunday))
                {
                    Console.WriteLine();
                    Console.WriteLine(dia.ToLongDateString());
                    Console.WriteLine(cultureAlemao.DateTimeFormat.GetDayName(dia.DayOfWeek) + " :" + dia);
                }
            }
        }
    }
}
