using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Commands
{
    public interface IPeliculasRepository
    {
        Peliculas PeliculaPorTitulo(string titulo);
        bool ExistePelicula(int peliculaId);
        bool ExistePelicula(string nombrePelicula);
        List<Peliculas> PeliculasDeHoy();
    }
}
