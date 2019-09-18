using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Estoque
    {
        ArrayList produtos;
        List<Categoria> categorias;

        public Estoque()
        {
            produtos = new ArrayList();
            categorias = new List<Categoria>();
        }
        public void mostrarRelatorio()
        {
            Console.Clear();
            Console.WriteLine("Relatório---------------------------------");
            foreach (object produto in produtos)
                if (produto.GetType() == typeof(Produto))
                {
                    Produto prod = (Produto)produto;
                    Console.WriteLine("\n------------------------------------------");
                    Console.WriteLine("Nome: " + prod.NomeProduto);
                    foreach (Categoria cat in categorias)
                        if (prod.CodCategoria == cat.Codigo)
                            Console.WriteLine("Descrição: " + cat.Descricao);
                    Console.WriteLine("Preço unitário: " + prod.PrecoUnitario);
                    Console.WriteLine("Quantidade em estoque: " + prod.QtdEstoque);
                    Console.WriteLine("------------------------------------------");
                }
        }
        public void mostrarInventario()
        {
            double valorTotal = 0;
            Console.Clear();
            foreach (object produto in produtos)
                if (produto.GetType() == typeof(Produto))
                {
                    Produto prod = (Produto)produto;
                    valorTotal += prod.PrecoUnitario * prod.QtdEstoque;
                }
            Console.WriteLine("Inventário----------------------------------");
            Console.WriteLine("R$ {0:f2}", valorTotal);
        }
        public void inserirProduto(Produto produto)
        {
            produtos.Add(produto);
        }
        public void adicionarCategoria(Categoria categoria)
        {
            categorias.Add(categoria);
        }
    }
}
