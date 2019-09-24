using System;
using System.Collections.Generic;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados times = new Dados();
            bool sair = false;
            int op = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("-------------MENU------------");
                Console.WriteLine("1 - Inserir time profissional");
                Console.WriteLine("2 - Inserir time de varzea...");
                Console.WriteLine("3 - Listar times.............");
                Console.WriteLine("4 - Sair.....................");
                Console.WriteLine("_____________________________");
                Console.Write("Digite uma opção:");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Profissional pro = new Profissional();
                        times.inserirTimeProfissional(pro);
                        sair = false;
                        Console.ReadKey();
                        break;
                    case 2:
                        Varzea var = new Varzea();
                        times.inserirTimeVarzea(var);
                        sair = false;
                        Console.ReadKey();
                        break;
                    case 3:
                        times.list();
                        break;
                    default:
                        sair = true;
                        break;
                }
            } while (!sair);
        }
    }
}