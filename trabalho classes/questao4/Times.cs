using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Times
    {
        public string nomeDotime { get; set; }
        public string presidente { get; set; }
        public string tecnico { get; set; }
        public string dataFundacao { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }

        public void readData()
        {
            Console.Clear();
            Console.Write("Informe o nome do time: ");
            nomeDotime = Console.ReadLine();
            Console.Write("Informe o presidente do time: ");
            presidente = Console.ReadLine();
            Console.Write("Informe o tecnico do time: ");
            tecnico = Console.ReadLine();
            Console.Write("informe a data de fundação do time: ");
            dataFundacao = Console.ReadLine();
            Console.Write("informe a cidade do time: ");
            cidade = Console.ReadLine();
            Console.Write("Informe o estado do time: ");
            uf = Console.ReadLine();
        }
    }
}
