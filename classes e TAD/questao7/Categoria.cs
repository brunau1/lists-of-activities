using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Categoria
    {
        private int codigo;
        public int Codigo
        {
            get { return codigo; }
            private set { codigo = value; }
        }
        public string Descricao { get; set; }

        public Categoria()
        {
            LerDados();
        }
        public void LerDados()
        {
            Console.WriteLine("cadastro de categoria--------\n");
            Console.WriteLine("Digite o código da categoria:");
            codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da categoria:");
            Descricao = Console.ReadLine();
        }
    }
}
