using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] aluno = new Aluno[50];
            for (int i = 0; i < 50; i++)
            {
                aluno[i] = new Aluno();
                aluno[i].lerDados();
            }
            Aluno resultado = new Aluno();
            resultado.mostraDados(aluno);
            Console.ReadKey();
        }
    }
}