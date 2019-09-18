using System;
using System.Collections.Generic;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Escola escola = new Escola();
            int op = 1;
            do
            {
                Console.Clear();
                Professor professor = new Professor();
                escola.adicionarFuncionario(professor);
                Console.WriteLine("\nDeseja cadastrar outro professor? 1 - sim | 0 - nao");
                op = int.Parse(Console.ReadLine());
            } while (op == 1);
            do
            {
                Console.Clear();
                Administrativo admin = new Administrativo();
                escola.adicionarFuncionario(admin);
                Console.WriteLine("\nDeseja cadastrar outro admin? 1 - sim | 0 - nao");
                op = int.Parse(Console.ReadLine());
            } while (op == 1);
            Console.Clear();
            escola.listarFuncionarios();
        }
    }
}