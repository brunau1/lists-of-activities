using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Locadora
    {
        public void listFilms(List<Filme> filmes)
        {
            foreach (Filme filme in filmes)
            {
                Console.WriteLine("Nome do filme: "+filme.nomeFilme);
                Console.WriteLine("Nome do diretor: "+filme.nomeDiretor);
                Console.WriteLine("Categoria: "+filme.categoria);
                Console.WriteLine("Duração: "+filme.duracao);
            }
        }
        public void listFilmsByCategory(List<Filme> filmes)
        {
            Console.WriteLine("Diigite a categoria que deseja consultar");
            string categoria = Console.ReadLine();
            
            foreach (Filme filme in filmes)
            {
                if (filme.categoria == categoria)
                {
                    Console.WriteLine("Nome do filme: " + filme.nomeFilme);
                    Console.WriteLine("Nome do diretor: " + filme.nomeDiretor);
                    Console.WriteLine("Categoria: " + filme.categoria);
                    Console.WriteLine("Duração: " + filme.duracao);
                }
            }
        }
    }
}
