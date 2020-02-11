using enumeracao.Entities;
using enumeracao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {

                Id = 1089,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

        }
    }
}
