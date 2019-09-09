using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            double treeA = 0.80, treeB = 1.30;
            int cont = 0;

            while (treeA < treeB)
            {
                cont++;
                treeA += 12.0;
                treeB += 8.0;
            }
            Console.WriteLine("A arvore A ficará maior que a arvore B em {0} ano(s).", cont);
            Console.ReadKey();
        }
    }
}
