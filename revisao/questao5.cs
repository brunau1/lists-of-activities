using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] v1, v2, soma, dif;
            Random rand = new Random();
            v1 = v2 = soma = dif = new int[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    v1[i, j] = rand.Next(50);
                    v2[i, j] = rand.Next(50);
                }
            Console.WriteLine("V1:   ");
            mostraMatrix(v1);

            Console.WriteLine();
            Console.WriteLine("V2:   ");
            mostraMatrix(v2);

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    soma[i, j] = v1[i, j] + v2[i, j];

            Console.WriteLine();
            Console.WriteLine("soma: ");
            mostraMatrix(soma);

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    dif[i, j] = v1[i, j] - v2[i, j];

            Console.WriteLine();
            Console.WriteLine("Diferença: ");
            mostraMatrix(dif);
            Console.ReadKey();
        }

        static void mostraMatrix(int[,] M)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write("   " + M[i, j]);
                Console.WriteLine();
            }
        }
    }
}
