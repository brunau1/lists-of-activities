using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Passeio : Veiculo
    {
        public bool possuiArCondicionado { get; set; }
        public string tipoCombustivel { get; set; }
        public int numPortas { get; set; }


        public Passeio()
        {
            lerDados();
        }

        public void lerDados()
        {
            base.lerDados();
            string resposta;
            Console.WriteLine("Possui ar condicionado? sim ou nao ");
            resposta = Console.ReadLine();
            possuiArCondicionado = resposta == "sim" ? true : false;
            Console.WriteLine("Informe o tipo de combustivel:");
            tipoCombustivel = Console.ReadLine();
            Console.WriteLine("Informe a quantidade de portas: ");
            numPortas = int.Parse(Console.ReadLine());
        }
        public double calculaValorLocacao()
        {
            double valorDeLocacao = valorKmRodado * (kmInicial - kmInicial);
            return valorDeLocacao;
        }
    }
}
