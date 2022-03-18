using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Commands;
using Domain.Entities;

namespace AccessData.Commands
{
    public class FuncionesRepository: IFuncionesRepository
    {
        private readonly CineContext _context;
        public FuncionesRepository(CineContext context)
        {
            _context = context;
        }

        public Funciones EliminarFuncion(Funciones funcion)
        {
            _context.Remove(funcion);
            return funcion;
        }

        public bool ExisteFuncion(int funcionId)
        {
            return _context.Funciones.Where(x => x.FuncionId == funcionId).Any();
        }

        public IEnumerable<Funciones> Funciones(DateTime fecha, string titulo)
        {
            var peli = _context.Peliculas.Single(peli => peli.Titulo.ToLower() == titulo.ToLower());
            
            return _context.Funciones.Where(f => (f.PeliculaId == peli.PeliculaId)
                && (f.Fecha == fecha)).ToList().OrderBy(x=>x.Horario);
        }

        public IEnumerable<Funciones> FuncionesDePelicula(int peliculaId)
        {
            return _context.Funciones.Where(funcion => funcion.PeliculaId == peliculaId)
                .OrderBy(f => f.Fecha)
                .ThenBy(f => f.Horario).ToList();
        }

        public IEnumerable<Funciones> FuncionesPorFecha(DateTime fecha)
        {
            return _context.Funciones.Where(f =>(f.Fecha == fecha)).ToList().OrderBy(x => x.Horario);
        }

        public IEnumerable<Funciones> FuncionesPorFechaYSala(DateTime fecha, int salaId)
        {
            return _context.Funciones.Where(x => x.Fecha == fecha && x.SalaId == salaId).ToList();
        }
    }
}