using System;
using System.Collections.Generic;
using System.Linq;

namespace OrientadoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa1 = new Pessoa();
            var pessoa2 = new Pessoa();

            LerDadosPessoa(pessoa1, "Dados da primeira pessoa ");
            LerDadosPessoa(pessoa2, "Dados da segunda pessoa ");

            var nomeCompleto = pessoa1.ObterNomeCompleto();

            pessoa2.CPF = "52733929";

            Console.WriteLine("Mais velha é: " +
                (pessoa1.Idade > pessoa2.Idade ?
                pessoa1.Nome : pessoa2.Nome));

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine("Mais velha é: " + pessoa1.Nome);
            }
            else
            {
                Console.WriteLine("Mais velha é: " + pessoa2.Nome);
            }

            var pessoas = new List<Pessoa> { pessoa1, pessoa2 };

            Pessoa pessoaMaisVelha = pessoas.OrderByDescending(x => x.Idade).First();

            Console.WriteLine("Mais velha é: " + pessoaMaisVelha.Nome);

            //pessoaMaisVelha = pessoas.Aggregate(
            //    (x, y) => x.Idade > y.Idade ? x : y);
        }

        private static void LerDadosPessoa(Pessoa pessoa, String mensagem)
        {
            Console.WriteLine(mensagem);
            Console.Write("Nome: ");
            pessoa.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = 0;
            Int32.TryParse(Console.ReadLine(), out idade);
            pessoa.Idade = idade;
        }

        private static void DiasDaSemana()
        {
            DiaSemana dia = DiaSemana.Domingo;
            var diaExtenso = "";

            switch (dia)
            {
                case DiaSemana.Segunda:
                case DiaSemana.Terca:

                    break;
                case DiaSemana.Quarta:
                    break;
                case DiaSemana.Quinta:
                    break;
                case DiaSemana.Sexta:
                    break;
                case DiaSemana.Sabado:
                    break;
                case DiaSemana.Domingo:
                    break;
                default:
                    break;
            }

        }

        private static void TrabalharString()
        {
            string original = "A;B;C;D;E F;G;H;J";

            string[] s1 = original.Split(';');
            string join = String.Join(";", s1);

            string padLeft = original.PadLeft(20, '*');
            string padRight = original.PadRight(20, '&');
        }
    }
}
