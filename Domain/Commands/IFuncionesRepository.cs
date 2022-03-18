using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Domain.Commands
{
    public interface IFuncionesRepository
    {
        IEnumerable<Funciones> Funciones(DateTime dia, string titulo);
        IEnumerable<Funciones> FuncionesPorFecha(DateTime fecha);
        IEnumerable<Funciones> FuncionesPorFechaYSala(DateTime fecha, int salaId);
        IEnumerable<Funciones> FuncionesDePelicula(int peliculaId);
        Funciones EliminarFuncion(Funciones funcion);
        bool ExisteFuncion(int funcionId);
    }
}
