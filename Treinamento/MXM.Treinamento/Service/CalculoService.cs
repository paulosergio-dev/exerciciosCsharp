using MXM.Treinamento.Entity;
using System;
using System.Collections.Generic;

namespace MXM.Treinamento.Service
{
    public class CalculoService
    {
        public static Decimal Max(Decimal d1, Decimal d2)
        {
            return d1 > d2 ? d1 : d2;
        }

        public static Decimal Sum(Decimal d1, Decimal d2)
        {
            return d1 + d2;
        }

        public static Decimal Square(Decimal d1)
        {
            return d1 * d1;
        }        
    }
}
