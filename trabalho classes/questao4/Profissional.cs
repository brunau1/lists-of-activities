using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Profissional : Times
    {
        public Profissional()
        {
            readData();
        }
        public string patrocinador { get; set; }

        public void readData()
        {
            base.readData();
            Console.Write("Informe o patrocinador: ");
            patrocinador = Console.ReadLine();
        }
    }
}
