using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Carga : Veiculo
    {
        public double capacidadeCarga { get; set; }


        public Carga()
        {
            lerDados();
        }

        public void lerDados()
        {
            base.lerDados();
            Console.WriteLine("Digite a capacidade de carga do veiculo: (Ton)");
            capacidadeCarga = float.Parse(Console.ReadLine());
        }
        public double calculaValorLocacao()
        {
            double valorDeLocacao = valorKmRodado * (kmInicial - kmInicial);
            valorDeLocacao += valorDeLocacao * 0.1;
            return valorDeLocacao;
        }
    }
}
