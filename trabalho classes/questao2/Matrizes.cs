using System;

namespace AppTrab
{
    class Matrizes
    {
        public int[,] matriz;
        public int n, p;

        public Matrizes()
        {
            n = 3;
            p = 3;
            matriz = new int[n, p];
        }

        public Matrizes(bool isRandomic)
        {
            n = 3;
            p = 3;
            matriz = new int[n, p];

            if (!!isRandomic)
                preencheMatriz();
        }

        public Matrizes(int linhas, int colunas)
        {
            n = linhas;
            p = colunas;
            matriz = new int[n, p];
        }

        public Matrizes(int linhas, int colunas, bool isRandomic)
        {
            n = linhas;
            p = colunas;
            matriz = new int[n, p];

            if (!!isRandomic)
                preencheMatriz();

        }

        public void listar()
        {
            Console.Clear();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    Console.Write("{0,6}", matriz[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private void preencheMatriz()
        {
            Console.Clear();
            Console.Write("informe o limite minimo: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("informe o limite maximo: ");
            int max = int.Parse(Console.ReadLine());
            Random rand = new Random();

            for (int i = 0; i < n; i++)
                for (int j = 0; j < p; j++)
                    matriz[i, j] = rand.Next(min, max);
        }
    }
}
