using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Produto
    {
        public string NomeProduto { get; set; }
        public double PrecoUnitario { get; set; }

        private int codcategoria;
        public int CodCategoria
        {
            get { return codcategoria; }
            set { codcategoria = value; }
        }
        private int qtdestoque;
        public int QtdEstoque
        {
            get { return qtdestoque; }
            set { qtdestoque = value; }
        }

        public Produto()
        {
            LerDados();
        }
        public void LerDados()
        {
            Console.WriteLine("cadastro de produto------\n");
            Console.WriteLine("Digite o nome do produto:");
            NomeProduto = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto:");
            PrecoUnitario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o código da categoria do produto:");
            codcategoria = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade do produto em estoque:");
            qtdestoque = int.Parse(Console.ReadLine());
        }
    }
}