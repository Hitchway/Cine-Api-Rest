using Domain.Commands;
using Domain.DTOs;
using Domain.Entities;
using System.Collections;
using System.Collections.Generic;

namespace Application.Services
{
    public interface IPeliculasService
    {
        Peliculas PeliculaPorId(int id);
        Peliculas PeliculaPorTitulo(string titulo);
        bool ExistePelicula(int peliculaId);
        bool ExistePelicula(string peliculaTitulo);
        Peliculas ActualizarPelicula(PeliculasDto pelicula, int peliculaId);
        IEnumerable<Peliculas> ListaPeliculas();
        List<Peliculas> ListaPeliculasDeHoy();
    }
    public class PeliculasService: IPeliculasService
    {
        private readonly IGenericRepository _repository;
        private readonly IPeliculasRepository _repositoryPeli;
        public PeliculasService(IGenericRepository repository, IPeliculasRepository repositoryPeli)
        {
            _repository = repository;
            _repositoryPeli = repositoryPeli;
        }

        public Peliculas ActualizarPelicula(PeliculasDto pelicula, int peliculaId)
        {
            var entidad = _repository.GetById<Peliculas>(peliculaId);
            entidad.Titulo = pelicula.Titulo;
            entidad.Poster = pelicula.Poster;
            entidad.Trailer = pelicula.Trailer;
            entidad.Sinopsis = pelicula.Sinopsis;
            _repository.Update<Peliculas>(entidad);
            return entidad;
        }

        public bool ExistePelicula(int peliculaId)
        {
            return _repositoryPeli.ExistePelicula(peliculaId);
        }

        public bool ExistePelicula(string peliculaTitulo)
        {
            return _repositoryPeli.ExistePelicula(peliculaTitulo);
        }

        public IEnumerable<Peliculas> ListaPeliculas()
        {
            List<Peliculas> listaPelis = _repository.GetAll<Peliculas>();
            listaPelis.Sort((x, y) => x.Titulo.CompareTo(y.Titulo));
            return listaPelis;
        }

        public List<Peliculas> ListaPeliculasDeHoy()
        {
            return _repositoryPeli.PeliculasDeHoy();
        }

        public Peliculas PeliculaPorId(int peliculaId)
        {
            return _repository.GetById<Peliculas>(peliculaId);
        }

        public Peliculas PeliculaPorTitulo(string titulo)
        {
            return _repositoryPeli.PeliculaPorTitulo(titulo);
        }
    }
}
