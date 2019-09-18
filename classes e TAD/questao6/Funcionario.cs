using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Funcionario
    {
        public string nome { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string dataAdmissao { get; set; }
        public string dataNacimento { get; set; }
        public string nomePai { get; set; }
        public string nomeMae { get; set; }
        public string identidade { get; set; }
        public string cpf { get; set; }
        public string carteiraDeTrabalho { get; set; }

        public void lerDados()
        {
            Console.WriteLine("Digite o nome do funcionario: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o endereco do funcionario: ");
            endereco = Console.ReadLine();
            Console.WriteLine("Digite o telefone no funcionario: ");
            telefone = Console.ReadLine();
            Console.WriteLine("Digite o email do funcionario: ");
            email = Console.ReadLine();
            Console.WriteLine("Digite a data de admissao do funcionario: ");
            dataAdmissao = Console.ReadLine();
            Console.WriteLine("Digite a data de nascimento: ");
            dataNacimento = Console.ReadLine();
            Console.WriteLine("Digite o nome da mae: ");
            nomeMae = Console.ReadLine();
            Console.WriteLine("Digite o nome do pai: ");
            nomePai = Console.ReadLine();
            Console.WriteLine("Digite a identidade do funcionario: ");
            identidade = Console.ReadLine();
            Console.WriteLine("Digite o cpf do funcionario: ");
            cpf = Console.ReadLine();
            Console.WriteLine("Digite a carteira de trabalho do funcionario: ");
            carteiraDeTrabalho = Console.ReadLine();
        }
        public void mostrarDados()
        {
            Console.WriteLine($"\nFuncionario: {nome}====================");
            Console.WriteLine($"endereco: {endereco}");
            Console.WriteLine($"telefone: {telefone}");
            Console.WriteLine($"email: {email}");
            Console.WriteLine($"data de admissao: {dataAdmissao}");
            Console.WriteLine($"data de nascimento: {dataNacimento}");
            Console.WriteLine($"nome da mae: {nomeMae}");
            Console.WriteLine($"nome do pai: {nomePai}");
            Console.WriteLine($"identidade: {identidade}");
            Console.WriteLine($"cpf: {cpf}");
            Console.WriteLine($"carteira de trabalho: {carteiraDeTrabalho}");
        }
    }
}
