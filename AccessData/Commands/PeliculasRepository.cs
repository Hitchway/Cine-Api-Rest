using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Commands;
using Domain.Entities;

namespace AccessData.Commands
{
    public class PeliculasRepository: IPeliculasRepository
    {
        private readonly CineContext _context;
        public PeliculasRepository(CineContext context)
        {
            _context = context;
        }
        public Peliculas PeliculaPorTitulo(string titulo)
        {
            return _context.Peliculas.Single(peli=>peli.Titulo.ToLower()==titulo.ToLower());
        }
        public bool ExistePelicula(int peliculaId)
        {
            return (_context.Peliculas
                .Where(pelicula => pelicula.PeliculaId == peliculaId)
                .ToList().Count > 0);
        }

        public bool ExistePelicula(string nombrePelicula)
        {
            return (_context.Peliculas.Where(pelicula => pelicula.Titulo.ToLower() == nombrePelicula.ToLower()).Any());
        }
        public List<Peliculas> PeliculasDeHoy()
        {
            var peliculas = (from f in _context.Funciones
                             join p in _context.Peliculas
                             on f.PeliculaId equals p.PeliculaId
                             where f.Fecha == DateTime.Now.Date
                             select new Peliculas
                             {
                                 PeliculaId=p.PeliculaId,
                                 Sinopsis=p.Sinopsis,
                                 Trailer=p.Trailer,
                                 Poster = p.Poster,
                                 Titulo=p.Titulo
                             }).ToList();

            return peliculas.GroupBy(x => x.PeliculaId).Select(x => x.First()).ToList();
        }
    }
}