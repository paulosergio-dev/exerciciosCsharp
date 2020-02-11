using System;
using System.Globalization;

namespace exercicioFixacao196.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public Double Amount { get; set; }
        
        public Installment(DateTime dueDate, Double amount)
        {
            DueDate = dueDate;

            Amount = amount;
        }
        public Installment () { }
        public override string ToString()
        {
            return "dueDate: "
            + DueDate.ToString("F2", CultureInfo.InvariantCulture)
            + "\nAmount: "
            + Amount.ToString("F2", CultureInfo.InvariantCulture);
            
        }

    }
}
