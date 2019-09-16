using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Filme
    {
        public string nomeFilme { get; set; }
        public string duracao { get; set; }
        public string nomeDiretor { get; set; }
        public string categoria { get; set; }

        public void lerDados()
        {
            Console.WriteLine("Digite o nome do filme: ");
            nomeFilme = Console.ReadLine();
            Console.WriteLine("Digite a duração do filme: ");
            duracao = Console.ReadLine();
            Console.WriteLine("Digite o nome do diretor: ");
            nomeDiretor = Console.ReadLine();
            Console.WriteLine("Digite a categoria; ");
            categoria = Console.ReadLine();
        }
    }
}