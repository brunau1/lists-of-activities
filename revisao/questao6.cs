using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v1, v2, resultante;
            int contElements = 0, cont = 0;
            v1 = new int[10];
            v2 = new int[10];
            resultante = new int[20];

            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.Write("Digite um numero para a {0}° posição do primeiro vetor: ", i + 1);
                v1[i] = int.Parse(Console.ReadLine());
                Console.Write("Digite um numero para a {0}° posição do segundo vetor: ", i + 1);
                v2[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.Write("V1:   ");
            for (int i = 0; i < 10; i++)
                Console.Write("   " + v1[i]);

            Console.WriteLine();
            Console.Write("V2:   ");
            for (int i = 0; i < 10; i++)
                Console.Write("   " + v2[i]);

            for (int i = 0; i < 20; i++)
            {
                if (i < 10)
                {
                    for (int j = 0; j < 10; j++)
                        if (v1[i] != v2[j])
                            cont++;
                    if (cont == 10)
                    {
                        resultante[i] = v1[i];
                        contElements++;
                    }
                    cont = 0;
                }
                if (i >= 10 && i < 20)
                {
                    for (int j = 0; j < 10; j++)
                        if (v2[i - 10] != v1[j])
                            cont++;
                    if (cont == 10)
                    {
                        resultante[i] = v2[i - 10];
                        contElements++;
                    }
                    cont = 0;
                }
            }

            Console.WriteLine();
            Console.Write("resultante: ");
            for (int i = 0; i < contElements; i++)
                Console.Write("   " + resultante[i]);
            Console.ReadKey();
        }
    }
}
