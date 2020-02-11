using MXM.Treinamento.Entity;
using System;
using System.Collections.Generic;

namespace MXM.Treinamento.Service
{
    public static class ExtensaoService
    {
        public static void ExibirProduto(this List<Produto> produtos)
        {
            produtos.ForEach(x => Console.WriteLine(x.ToString()));
        }
    }
}
