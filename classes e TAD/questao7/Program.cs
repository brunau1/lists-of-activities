using System;
using System.Collections.Generic;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Estoque estoque = new Estoque();
            int op = 1;
            do
            {
                Console.Clear();
                Categoria categoria = new Categoria();
                estoque.adicionarCategoria(categoria);
                Console.WriteLine("\nDeseja cadastrar outra categoria? 1 - sim | 0 - nao");
                op = int.Parse(Console.ReadLine());
            } while (op == 1);
            do
            {
                Console.Clear();
                Produto produto = new Produto();
                estoque.inserirProduto(produto);
                Console.WriteLine("\nDeseja cadastrar outro produto? 1 - sim | 0 - nao");
                op = int.Parse(Console.ReadLine());
            } while (op == 1);
            Console.Clear();
            estoque.mostrarRelatorio();
            estoque.mostrarInventario();
        }
    }
}