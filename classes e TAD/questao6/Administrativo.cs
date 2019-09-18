using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Administrativo : Funcionario
    {
        public string cargo { get; set; }
        public string setor { get; set; }

        public Administrativo()
        {
            lerDados();
        }
        public void lerDados()
        {
            Console.Clear();
            base.lerDados();
            Console.WriteLine("Digite o cargo do funcionario: ");
            cargo = Console.ReadLine();
            Console.WriteLine("Digite o setor do funcionario: ");
            setor = Console.ReadLine();
        }
        public void mostrarDados()
        {
            base.mostrarDados();
            Console.WriteLine($"Cargo: {cargo}");
            Console.WriteLine($"Setor: {setor}");
            Console.WriteLine($"Administrativo===========================");
        }
    }
}
