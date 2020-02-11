using System;
using System.Collections.Generic;
using System.Linq;
using exercicioAdrianoDia27.Entidades;
using System.Globalization;


namespace exercicioAdrianoDia27
{
    delegate void BinaryNumericOperation();

    class Program
    {

        public static void ExibirMensagemNoConsole(IList<Produto> produtos)
        {
            foreach (var item in produtos)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto> {
                   new Produto {Nome = "TV", Preco =  1400.0M },
                   new Produto {Nome = "Computador", Preco =  2400.0M },
                   new Produto {Nome = "Celular", Preco =   900.0M },
                   new Produto {Nome = "Geladeira", Preco =  3050.0M }
            };

            produtos.Sort((p1, p2) => p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper()));

            foreach (Produto p in produtos)
            {
                Console.WriteLine(p);
            }

            Console.Write("Quanto pretende Gastar? ");
            Decimal gasto = Decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var prod = produtos.Where(e => e.Preco <= gasto);

            Console.WriteLine("Os Produtos que vc pode comprar são: ");

            foreach (var Produto in prod)
            {
                Console.WriteLine(Produto.Nome + " " + Produto.Preco);
            }

            Console.WriteLine("Inserir cupom de desconto");
            String cupom = Console.ReadLine();

            Action<Produto> acao = (p) =>
            {
                if (cupom == "MXM10")
                {
                    p.Preco -= p.Preco * 0.1M;
                }
                if (cupom == "mxm10")
                {
                    p.Preco -= p.Preco * 0.1M;
                }
            };

            produtos.ForEach(acao);

            
            Console.ReadLine();

        }
      }
}