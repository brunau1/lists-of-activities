using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v1, v2, soma;
            Random rand = new Random();
            v1 = v2 = soma = new int[10];
            for (int i = 0; i < 10; i++)
            {
                v1[i] = rand.Next(50);
                v2[i] = rand.Next(50);
            }
            Console.Write("V1:   ");
            for (int i = 0; i < 10; i++)
                Console.Write("   " + v1[i]);
            Console.WriteLine();
            Console.Write("V2:   ");
            for (int i = 0; i < 10; i++)
                Console.Write("   " + v2[i]);
            for (int i = 0; i < 10; i++)
                soma[i] = v1[i] + v2[i];
            Console.WriteLine();
            Console.Write("Soma: ");
            for (int i = 0; i < 10; i++)
                Console.Write("   " + soma[i]);
            Console.ReadKey();
        }
    }
}
