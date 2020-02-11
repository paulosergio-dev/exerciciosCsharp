using System;

namespace TreinamentoMXM
{
    public class Funcionario
    {
        public Funcionario()
        {
            this.GrupoSanguineo = new GrupoSanguineo();
        }

        public Funcionario(String nome)
        {
            this.Nome = nome;
        }

        public Int32 Matricula { get; set; }
        public String Nome { get; set; }
        public String SobreNome { get; set; }
        public String CPF { get; set; }
        public Boolean Ativo { get; set; }
        public DateTime DataNascimento { get; set; }
        public GrupoSanguineo GrupoSanguineo { get; set; }

        public String ObterNomeCompleto()
        {
            return Nome + " " + SobreNome;
        }
    }
}
