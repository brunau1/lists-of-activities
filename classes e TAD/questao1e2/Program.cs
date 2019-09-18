using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.lerDados();
            aluno.mostraDados();
            Console.ReadKey();
        }
    }
}