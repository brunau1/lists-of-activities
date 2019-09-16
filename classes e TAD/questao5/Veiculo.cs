using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Veiculo
    {
        public string placa { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string anoDeFabricacao { get; set; }
        public double valorKmRodado { get; set; }
        public double kmInicial { get; set; }
        public double kmFinal { get; set; }
        public void lerDados()
        {
            Console.WriteLine("Digite a placa do veiculo: ");
            placa = Console.ReadLine();
            Console.WriteLine("Digite o modelo do veiculo: ");
            modelo = Console.ReadLine();
            Console.WriteLine("Digite a marca do veiculo: ");
            marca = Console.ReadLine();
            Console.WriteLine("Digite o ano de fabricação: ");
            anoDeFabricacao = Console.ReadLine();
            Console.WriteLine("Digite o valor do Km rodado: ");
            valorKmRodado = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a kilometragem inicial: ");
            kmInicial = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a kilometragem final: ");
            kmFinal = double.Parse(Console.ReadLine());
        }
    }
}
