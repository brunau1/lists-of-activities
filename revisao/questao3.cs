using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            for (int i = 6; i <= 1000; i++)
            {
                for (int j = 1; j < i; j++)
                    if (i % j == 0)
                        soma += j;
                if(soma == i)
                    Console.WriteLine("O numero {0} é perfeito", i);
                soma = 0;
            }

            Console.ReadKey();
        }
    }
}
