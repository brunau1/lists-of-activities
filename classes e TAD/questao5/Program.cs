using System;
using System.Collections.Generic;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Locadora locadora = new Locadora();
            int op = 1;
            do
            {
                Carga vCarga = new Carga();
                locadora.veiculos.Add(vCarga);
                Console.WriteLine("Deseja cadastrar outro veiculo de carga? 1 - sim | 0 - nao");
                op = int.Parse(Console.ReadLine());
            } while (op == 1);
            do
            {
                Passeio vPasseio = new Passeio();
                locadora.veiculos.Add(vPasseio);
                Console.WriteLine("Deseja cadastrar outro veiculo de passeio? 1 - sim | 0 - nao");
                op = int.Parse(Console.ReadLine());
            } while (op == 1) ;
            Console.Clear();
            Console.WriteLine("Digite a placa do veiculo que deseja consultar o valor de locação: ");
            string placa = Console.ReadLine();
            locadora.informaValorDeLocacao(placa);
            Console.ReadKey();
        }
    }
}