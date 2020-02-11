using MXM.Treinamento.Entity;
using MXM.Treinamento.Service;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MXM.Treinamento
{
    class Program
    {
        delegate void MensagemConsole(IList<Produto> produtos);
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>
            {
                new Produto { Nome = "TV", Preco = 1400.0M },
                new Produto { Nome = "Computador", Preco = 2400.0M },
                new Produto { Nome = "Celular", Preco = 900.0M },
                new Produto { Nome = "Geladeira", Preco = 3050.0M },
            };

            //Listar produtos por ordem alfabetica
            produtos
                .Sort((p1, p2) => p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper()));

            //Escrever no console
            MensagemConsole msgCw = ExibirMensagemNoConsole;

            msgCw.Invoke(produtos);

            Console.WriteLine("Até quanto deseja gastar?");
            Decimal valorDigitado = Decimal.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);

            //Filtrar por preço
            List<Produto> produtosDentroOrcamento
                = produtos
                .Where((x) => x.Preco <= valorDigitado)
                .ToList();

            //Escrever em tela
            produtosDentroOrcamento
               .ForEach(x
               => Console.WriteLine(("Os produtos dentro da faixa de preço selecionados são: "
               + x.ToString())));

            Console.WriteLine("Inserir cupom de desconto");
            String cupom = Console.ReadLine();

            //Calcular desconto
            Action<Produto> acao = (p) =>
            {
                if (cupom == "MXM10")
                {
                    p.Preco -= p.Preco * 0.1M;
                }
            };

            produtos.ForEach(acao);

            msgCw.Invoke(produtos);
        }

        public static void ExibirMensagemNoConsole(IList<Produto> produtos)
        {
            foreach (var item in produtos)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
