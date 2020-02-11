using System;

namespace OrientadoObjeto
{
    public class Pessoa
    {
        public String Nome { get; set; }
        public String SobreNome { get; set; }
        public Int32 Idade { get; set; }
        public String CPF { get; set; }

        public String ObterNomeCompleto()
        {
            return Nome + " " + SobreNome;
        }
    }
}
