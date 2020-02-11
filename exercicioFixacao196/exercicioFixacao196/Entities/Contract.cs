using System;
using System.Collections.Generic;


namespace exercicioFixacao196.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public List<Installment> installments { get; set; } = new List<Installment>();

        public Contract() { }


        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

    }

}

