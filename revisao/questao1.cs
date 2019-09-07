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
            int n;
            double s1 = 0, s2 = 100;
            Console.WriteLine("Digite um numero inteiro: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
                s1 += (double)i / i + 1.0;

            for (int i = 1; i <= n; i++)
                if (i % 2 == 0)
                    s2 += (double)i;
                else
                    s2 -= (double)i;

            Console.Clear();
            Console.WriteLine("Resultado da série um: {0:f2}", s1);
            Console.WriteLine("Resultado da série dois: {0:f2}", s2);

            Console.ReadKey();
        }
    }
}
