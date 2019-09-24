using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Varzea : Times
    {
        public Varzea()
        {
            readData();
        }
        public string bairro { get; set; }

        public void readData()
        {
            base.readData();
            Console.Write("Informe o Bairro do time: ");
            bairro = Console.ReadLine();
        }
    }
}
