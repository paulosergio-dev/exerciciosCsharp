using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            double real, dolar, cotacao;

            Console.Write("Digite quantos R$ quer converter para U$: ");
            real = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a cotação do Dólar: ");
            dolar = Convert.ToDouble(Console.ReadLine());

            cotacao = real * dolar;

            Console.WriteLine();
            Console.WriteLine("O resultado da conversão é: U$ " + cotacao);
            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}