using System;

namespace Application
{
    interface IAnaliseCombinatoria
    {
        double calcula(int n, int p);
    }
    class Fatorial
    {
        public static int calcFatorial(int n)
        {
            int fatorial = 1;
            for (int i = n; i > 0; i--)
                fatorial *= i;
            return fatorial;
        }
    }
    class Combinacao : IAnaliseCombinatoria
    {
        public double calcula(int n, int p)
        {
            return Fatorial.calcFatorial(n) / (Fatorial.calcFatorial(p) * Fatorial.calcFatorial(n - p));
        }
    }
    class Permutacao : IAnaliseCombinatoria
    {
        public double calcula(int n, int p)
        {
            return Fatorial.calcFatorial(n);
        }
    }
    class Arranjo : IAnaliseCombinatoria
    {
        public double calcula(int n, int p)
        {
            return Fatorial.calcFatorial(n) / Fatorial.calcFatorial(n - p);
        }
    }
    class Calculo
    {
        private IAnaliseCombinatoria calc;
        public Calculo(IAnaliseCombinatoria tipoCalc)
        {
            calc = tipoCalc;
        }
        public double ExecutaCalculo(int n, int p)
        {
            return calc.calcula(n, p);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n, p;
            Console.WriteLine("Digite o valor de N:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de P:");
            p = int.Parse(Console.ReadLine());

            Console.WriteLine($"Arranjo: {new Calculo(new Arranjo()).ExecutaCalculo(n, p)}");
            Console.WriteLine($"Combinação: {new Calculo(new Combinacao()).ExecutaCalculo(n, p)}");
            Console.WriteLine($"Permutacao: {new Calculo(new Permutacao()).ExecutaCalculo(n, p)}");

            Console.ReadKey();
        }
    }
}