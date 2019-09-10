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

        public void LerDados()
        {
            Console.WriteLine("Digite o nome do produto:");
            NomeProduto = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto:");
            PrecoUnitario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o código da categoria do produto:");
            codcategoria = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade do produto em estoque:");
            qtdestoque = int.Parse(Console.ReadLine());
        }

        public void MostraRelatorio(List<Produto> produtos, List<Categoria> categorias)
        {
                Console.WriteLine("Relatório---------------------------------");
            foreach (Produto prod in produtos)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Nome: "+prod.NomeProduto);
                foreach(Categoria cat in categorias)
                    if(prod.CodCategoria == cat.Codigo)
                        Console.WriteLine("Descrição: "+cat.Descricao);
                Console.WriteLine("Preço unitário: "+prod.PrecoUnitario);
                Console.WriteLine("Quantidade em estoque: "+prod.QtdEstoque);
                Console.WriteLine("------------------------------------------");
            }
        }
    }
    class Categoria
    {
        private int codigo;
        public int Codigo
        {
            get { return codigo; }
            private set { codigo = value; }
        }
        public string Descricao { get; set; }

        public void LerDados()
        {
            Console.WriteLine("Digite o código da categoria:");
            codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da categoria:");
            Descricao = Console.ReadLine();
        }
    }
}