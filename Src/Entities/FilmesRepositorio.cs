using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;
using DIO.Series;

namespace DIO.Filmes
{
    public class FilmesRepositorio : IRepositorio<Filmes>
    {
        private List<Filmes> listaFilmes = new List<Filmes>();
        public void Atualiza(int id, Filmes filmes)
        {
            listaFilmes[id] = filmes;
        }

        public void Exclui(int id)
        {
            listaFilmes.RemoveAt(id);
        }

        public void Insere(Filmes filmes)
        {
            listaFilmes.Add(filmes);
        }

        public List<Filmes> Lista()
        {
            return listaFilmes;
        }

        public Filmes RetornaPorId(int id)
        {
            return listaFilmes[id];
        }

        public int ProximoId()
        {
            return listaFilmes.Count;
        }
    }
}