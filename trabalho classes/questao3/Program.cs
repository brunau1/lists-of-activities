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
                Console.WriteLine("MENU--------------------");
                Console.WriteLine("1 - Inserir novo time...");
                Console.WriteLine("2 - Listar times........");
                Console.WriteLine("3 - Sair................");
                Console.WriteLine("________________________");
                Console.Write("Digite uma opção:");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Times time = new Times();
                        time.readData();
                        times.inserirTime(time);
                        sair = false;
                        Console.ReadKey();
                        break;
                    case 2:
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