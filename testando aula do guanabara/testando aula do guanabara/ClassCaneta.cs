using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testando_aula_do_guanabara
{
    class ClassCaneta
    {
        public string modelo { get; set; }
        public string cor { get; set; }

        public double ponta { get; set; }

        public int carga { get; set; }

        public bool tampada { get; set; }


        public void rabiscar ()
        {
            if (tampada)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine("Rabiscar");
            }
            
        }


        public bool 


    }
}
