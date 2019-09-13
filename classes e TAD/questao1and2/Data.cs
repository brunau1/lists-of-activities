using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Aluno
    {
        public string nome { get; set; }
        public string mail { get; set; }
        public string telefone { get; set; }
        public Data dataNascimento { get; set; }

        public Aluno()
        {
            dataNascimento = new Data();
        }
        public void lerDados()
        {
            Console.WriteLine("Digite o nome do aluno");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o email do aluno");
            mail = Console.ReadLine();
            Console.WriteLine("Digite o telefone do aluno");
            telefone = Console.ReadLine();
            Console.WriteLine("digite a data de nascimento");
            dataNascimento.lerDados();
        }
        public void mostraDados()
        {
            Console.Clear();
            Console.WriteLine("Nome: "+nome);
            Console.WriteLine("email: "+mail);
            Console.WriteLine("Telefone: "+telefone);
            Console.WriteLine("data de nascimento: ");
            dataNascimento.mostraDados();
        }
    }
    class Data
    {
        public string dia { get; set; }
        public string mes { get; set; }
        public string ano { get; set; }

        public void lerDados()
        {
            Console.WriteLine("digite o dia:");
            dia = Console.ReadLine();
            Console.WriteLine("digite o mes:");
            mes = Console.ReadLine();
            Console.WriteLine("digite o ano:");
            ano = Console.ReadLine();
        }
        public void mostraDados()
        {
            Console.WriteLine($"{dia}/{mes}/{ano}");
        }
    }
}
