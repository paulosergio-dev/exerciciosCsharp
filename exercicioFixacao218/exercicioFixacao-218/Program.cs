using System;
using System.Collections.Generic;
using System.Linq;
using exercicioFixacao218.Entities;
using System.Globalization;

namespace exercicioFixacao218.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<employee> funcionarios = new List<employee>() {
                new employee() {Nome = "Maria", Email = "maria@gmail.com", Salario = 3200.00  },
                new employee() {Nome = "Alex", Email = "alex@gmail.com", Salario = 1900.00   },
                new employee() {Nome = "Marco", Email = "marco@gmail.com", Salario = 1700.00   },
                new employee() {Nome = "Bob", Email = "bob@gmail.com", Salario = 3500.00   },
                new employee() {Nome = "Anna", Email = "anna@gmail.com", Salario = 2800.00 }
            };

            Console.Write("Enter salary: ", CultureInfo.InvariantCulture);
            double salarim = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var x1 = funcionarios.Where(e => e.Salario > salarim).OrderBy(e => e.Email);

            Console.WriteLine($"Email of people whose salary is more than {salarim}:", CultureInfo.InvariantCulture);
            foreach (var empregado in x1)
            {
                Console.WriteLine(empregado.Email);
            }

            Console.ReadLine();

        }
    }
}





            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = fields[2];

                    list.Add(new Entitites.Employee(name, email, double.Parse(fields[2], CultureInfo.InvariantCulture)));
                }
            }


            

        }
    }
}
