using System;
using System.Globalization;

namespace exercicioFixacao196
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");

            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy" ,CultureInfo.InvariantCulture);

            Console.WriteLine("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Console.WriteLine("Installments: ");

            foreach (var installment in contract.installments)
            {
                Console.WriteLine(installment);
            }
            Console.ReadLine();





        }
    }
}
