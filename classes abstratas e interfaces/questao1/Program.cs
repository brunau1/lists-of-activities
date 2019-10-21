using System;
using System.Collections.Generic;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, p;
            Operacoes op = new Operacoes();
            Combinacao comb = new Combinacao();
            Permutacao perm = new Permutacao();
            Arranjo arr = new Arranjo();

            Console.WriteLine("Digite o valor de N");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de P");
            p = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"Resultado combinação: {op.retornaCalculo(comb, n, p)}");
            Console.WriteLine($"Resultado arranjo: {op.retornaCalculo(arr, n, p)}");
            Console.WriteLine($"Resultado permutação: {op.retornaCalculo(perm, n, p)}");
            Console.ReadKey();
        }
    }
}