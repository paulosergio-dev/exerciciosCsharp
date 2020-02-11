using Course.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();
            Console.Write("Nome do arquivo a ser criado: ");
            string arq = Console.ReadLine();
            Console.WriteLine();

            string caminho = @"C:\Users\paulo.santos\Desktop\exercArquivos189" + arq;
            string subPasta = @"C:\Users\paulo.santos\Desktop\exercArquivos189\out";

            Console.Write("Digite o nome do arquivo + extensão (ex: Paulo.Pdf , Paulo.csv) : ");
            string saida = Console.ReadLine();
            Console.WriteLine();

            string arquivoDeSaida = subPasta + @"\" + saida;

            Directory.CreateDirectory(subPasta);

            try
            {
                Console.WriteLine("Quantos itens vão ser adcionados? : ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Nome : ");
                    string nome = Console.ReadLine();

                    Console.Write("Preço : ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Quantidades : ");
                    int qtd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Product(nome, preco, qtd));
                    Console.WriteLine();

                }

                foreach (Product prod in list)
                {
                    using (StreamWriter writer = new StreamWriter(caminho, true))
                    {
                        writer.WriteLine(prod.ToString());

                    }
                }
                foreach (Product prod in list)
                {
                    using (StreamWriter sw = File.AppendText(arquivoDeSaida))
                    {
                       sw.WriteLine(prod.Name + " -- " + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }

                }

            }
            catch (IOException)
            {
                Console.WriteLine("Error !");
            }

        }
    }
}