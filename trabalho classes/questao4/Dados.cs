using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Dados
    {
        ArrayList times;
        public Dados()
        {
            times = new ArrayList();
        }
        public void list()
        {
            Console.Clear();
            Console.WriteLine("Times---------------------------------------");
            foreach (object item in times)
            {
                if (item.GetType() == typeof(Profissional))
                {
                    Profissional time = (Profissional)item;
                    Console.WriteLine("\n------------------------------------------");
                    Console.WriteLine("Nome: " + time.nomeDotime);
                    Console.WriteLine("Presidente: " + time.presidente);
                    Console.WriteLine("Tecnico: " + time.tecnico);
                    Console.WriteLine("Data de fundação: " + time.dataFundacao);
                    Console.WriteLine("Cidade: " + time.cidade);
                    Console.WriteLine("Estado: " + time.uf);
                    Console.WriteLine("Patrocinador: " + time.patrocinador);
                    Console.WriteLine("------------------------------------------");
                }
                if (item.GetType() == typeof(Varzea))
                {
                    Varzea time = (Varzea)item;
                    Console.WriteLine("\n------------------------------------------");
                    Console.WriteLine("Nome: " + time.nomeDotime);
                    Console.WriteLine("Presidente: " + time.presidente);
                    Console.WriteLine("Tecnico: " + time.tecnico);
                    Console.WriteLine("Data de fundação: " + time.dataFundacao);
                    Console.WriteLine("Bairro: " + time.bairro);
                    Console.WriteLine("Cidade: " + time.cidade);
                    Console.WriteLine("Estado: " + time.uf);
                    Console.WriteLine("------------------------------------------");
                }
            }
            Console.ReadKey();
        }
        public void inserirTimeProfissional(Profissional time)
        {
            times.Add(time);
        }
        public void inserirTimeVarzea(Varzea time)
        {
            times.Add(time);
        }
    }
}
