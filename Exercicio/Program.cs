using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataDe = new DateTime(2010, 10, 10);

            DateTime dataAte = DateTime.Now;

            TimeSpan diferenca = dataAte.Subtract(dataDe);
            Console.WriteLine(diferenca.Days);
        }
    }
}
