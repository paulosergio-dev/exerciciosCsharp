using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioaula130.Utilities
{
    class OutsourceEmployee : Employee
    {
        public double additionalCharge { get; set; }

        public override double Payment()
        {
            return base.Payment() + additionalCharge;
        }
    }
}
