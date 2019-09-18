using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Professor : Funcionario
    {
        public double horasDeAula { get; set; }
        public string titulacao { get; set; }

        public Professor()
        {
            lerDados();
        }
        public void lerDados()
        {
            Console.Clear();
            base.lerDados();
            Console.WriteLine("Digite o numero de horas de aula semanais: ");
            horasDeAula = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a titulacao do professor: ");
            titulacao = Console.ReadLine();
        }
        public void mostrarDados()
        {
            base.mostrarDados();
            Console.WriteLine($"numero horas/aula semanais: {horasDeAula}");
            Console.WriteLine($"titulação: {titulacao}");
            Console.WriteLine($"Professor================================");
        }
    }
}
