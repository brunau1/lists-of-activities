using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Locadora
    {
        public ArrayList veiculos;

        public Locadora()
        {
            veiculos = new ArrayList();
        }
        public void informaValorDeLocacao(string placa)
        {
            foreach (object veiculo in veiculos)
            {
                if(veiculo.GetType() == typeof(Passeio))
                {
                    Passeio vPasseio = (Passeio)veiculo;
                    if(vPasseio.placa == placa)
                    {
                        Console.WriteLine($"Valor de locação: {vPasseio.calculaValorLocacao()}");
                    }
                }
                if (veiculo.GetType() == typeof(Carga))
                {
                    Carga vCarga = (Carga)veiculo;
                    if (vCarga.placa == placa)
                    {
                        Console.WriteLine($"Valor de locação: {vCarga.calculaValorLocacao()}");
                    }
                }
            }
        }
    }
}
