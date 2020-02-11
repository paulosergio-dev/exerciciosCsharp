using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioaula130.Utilities
{
    class Employee
    {
        public string name { get; set; }
        public double hours { get; set; }

        public double valuePerHour { get; set; }

        public virtual double Payment()
        {
            return valuePerHour * hours;
        }
    }


}
