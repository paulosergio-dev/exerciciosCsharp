namespace exercicioFixacao218.Entities
{
    class employee
    {
        public employee(string nome, string email, double salario)
        {
            Nome = nome;
            Email = email;
            Salario = salario;
        }

        public employee()
        {
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public double Salario { get; set; }

    }

}