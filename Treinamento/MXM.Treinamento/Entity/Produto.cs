using System;

namespace MXM.Treinamento.Entity
{
    public class Produto
    {
        public String Nome { get; set; }
        public Decimal Preco { get; set; }

        public override string ToString()
        {
            return Nome + ", " + Preco.ToString("F2");
        }
    }
}
