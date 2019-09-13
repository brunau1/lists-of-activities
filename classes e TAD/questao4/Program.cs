using System;
using System.Collections.Generic;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Locadora locadora = new Locadora();
            List<Filme> filmes = new List<Filme>();
            for (int i = 0; i < 5; i++)
            {
                Filme filme = new Filme();
                filme.lerDados();
                filmes.Add(filme);
            }
            locadora.listFilms(filmes);
            locadora.listFilmsByCategory(filmes);

            Console.ReadKey();
        }
    }
}