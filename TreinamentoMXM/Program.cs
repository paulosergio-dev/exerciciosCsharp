using System;
using System.Collections.Generic;
using System.Linq;

namespace TreinamentoMXM
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionario = new Funcionario();
            funcionario.Nome = "Daniel";
            funcionario.SobreNome = "Gomes";
            funcionario.GrupoSanguineo.TipoSanguineo = TipoSanguineo.A;
            funcionario.GrupoSanguineo.FatorRh = FatorRh.N;
            funcionario.DataNascimento = new DateTime(1992, 9, 21);

            String nomeCompleto = funcionario.ObterNomeCompleto();

            var funcionarios = new List<Funcionario>();

            funcionarios.Add(funcionario);

            foreach (Funcionario item in funcionarios)
            {
                String nome = item.ObterNomeCompleto();
                Console.WriteLine(nome);

                string original = nome;
                string s1 = original.ToUpper();
                string s2 = original.ToLower();
                string s3 = original.Trim();
                int n1 = original.IndexOf("bc");
                int n2 = original.LastIndexOf("bc");
                string s4 = original.Substring(3);
                string s5 = original.Substring(3, 5);
                string s6 = original.Replace('a', 'x');
                string s7 = original.Replace("abc", "xy");
                bool b1 = String.IsNullOrEmpty(original);
                bool b2 = String.IsNullOrWhiteSpace(original);

                Console.WriteLine(original.PadRight(20, '_'));
                original.Count(v => v == 'e');
            }           
        }

        private static String ObterFatorRh(GrupoSanguineo grupoSanguineo)
        {
            switch (grupoSanguineo.FatorRh)
            {
                case FatorRh.P:
                    return "Positivo";
                case FatorRh.N:
                    return "Negativo";
                default:
                    return "Fator Rh não informado";
            }
        }

        private static String ObterTipoSanguineo(GrupoSanguineo grupoSanguineo)
        {
            switch (grupoSanguineo.TipoSanguineo)
            {
                case TipoSanguineo.A:
                    return "A";
                case TipoSanguineo.B:
                    return "B";
                case TipoSanguineo.AB:
                    return "AB";
                case TipoSanguineo.O:
                    return "O";
                default:
                    return "Tipo sanguíneo não informado";
            }
        }
    }
}
