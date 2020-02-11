using System;

namespace exercicioAdrianoDia27.Entidades
{
    class Produto
    {
        public String Nome { get; set; }
        public Decimal Preco { get; set; }

        public Produto()
        { }
        public Produto(String nome, Decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public override String ToString()
        { return Nome + ", " + Preco.ToString("F2"); }

    }
}
