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
            int[,] M = new int[3, 3];
            int[] V;
            Random rand = new Random();

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    M[i, j] = rand.Next(10);
            V = extractElements(M);
            for (int i = 0; i < V.Length; i++)
                Console.Write("V[{0}]: {1}   ", i, V[i]);
            Console.ReadKey();
        }
        static int[] extractElements(int[,] M)
        {
            int length = 0;
            int pos = 0;
            int[] V;
            for (int i = 0; i < Math.Sqrt(M.Length); i++)
                for (int j = 0; j < Math.Sqrt(M.Length); j++)
                    if (i != j)
                        length++;
            V = new int[length];
            for (int i = 0; i < Math.Sqrt(M.Length); i++)
                for (int j = 0; j < Math.Sqrt(M.Length); j++)
                    if (i != j)
                    {
                        V[pos] = M[i, j];
                        pos++;
                    }
            return V;
        }
    }
}
