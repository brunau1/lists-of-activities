using System;

namespace Application
{
    abstract class Funcionario
    {
        public string nome { get; set; }
        public string matricula { get; set; }
        public double salario { get; set; }

        public virtual void cadastro()
        {
            Console.WriteLine("Digite o nome do funcionario:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a matricula do funcionario:");
            matricula = Console.ReadLine();
            Console.WriteLine("Digite o salario do funcionario:");
            salario = double.Parse(Console.ReadLine());
        }

        public abstract void mostraDados();
    }
    class Administrativo : Funcionario
    {
        public string setor { get; set; }
        public new void cadastro()
        {
            base.cadastro();
            Console.WriteLine("Digite o setor do funcionario:");
            setor = Console.ReadLine();
            Console.Clear();
        }
        public override void mostraDados()
        {
            Console.WriteLine();
            Console.WriteLine("Funcionário================");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Matricula: {matricula}");
            Console.WriteLine($"Salario: {salario}");
            Console.WriteLine($"Setor: {setor}");
            Console.WriteLine("===========================");
            Console.WriteLine();
        }
    }
    class Vendedor : Funcionario
    {
        public double percentual { get; set; }
        public new void cadastro()
        {
            base.cadastro();
            Console.WriteLine("Digite o percentual de comissão:");
            percentual = double.Parse(Console.ReadLine());
            Console.Clear();
        }
        public override void mostraDados()
        {
            Console.WriteLine();
            Console.WriteLine("Funcionário================");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Matricula: {matricula}");
            Console.WriteLine($"Salario: {salario}");
            Console.WriteLine($"Comissão: {percentual}%");
            Console.WriteLine("===========================");
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Administrativo admin = new Administrativo();
            Vendedor vendedor = new Vendedor();

            admin.cadastro();
            vendedor.cadastro();

            admin.mostraDados();
            vendedor.mostraDados();
        }
    }
}