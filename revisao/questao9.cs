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
            int[] V = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.Write("Digite um numero para a {0}° posição do primeiro vetor: ", i + 1);
                V[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            if(contElements(V) == 0)
                Console.WriteLine("Não há multiplos de 3 no vetor.");
            else
                Console.WriteLine("Há {0} multiplos de 3 no vetor.", contElements(V));
            Console.ReadKey();
        }
        static int contElements(int[] V)
        {
            int cont = 0;
            for (int i = 0; i < 10; i++)
                if (V[i] % 3 == 0)
                    cont++;
            return cont;
        }
    }
}
