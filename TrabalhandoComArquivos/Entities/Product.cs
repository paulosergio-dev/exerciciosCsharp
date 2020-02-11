using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComArquivos.Entities
{
    class Product
    {
     
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double Total()
        {
            return Price * Quantity;
        }
        public override string ToString()
        {
            return Name
                + " - "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " - "
                + Quantity;
        }
    }
}
