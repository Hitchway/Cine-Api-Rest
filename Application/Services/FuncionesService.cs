using Application.Validation;
using Domain.Commands;
using Domain.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Application.Services
{
    public interface IFuncionesService
    {
        IEnumerable<Funciones> Funciones(string fecha, string titulo);
        IEnumerable<Funciones> FuncionesPorFechaYTitulo(string fecha, string titulo);
        IEnumerable<Funciones> FuncionesPorFecha(string fecha);
        IEnumerable<Funciones> FuncionesDePelicula(int peliculaId);
        Funciones FuncionPorId(int funcionId);
        Funciones CrearFuncion(FuncionesDto funcion);
        int CantidadTicketsDisponibles(int funcionId);
        bool ExisteFuncion(int funcionId);
        void EliminarFuncion(int funcionId);
    }
    public class FuncionesService : IFuncionesService
    {
        private readonly IGenericRepository _repository;
        private readonly IFuncionesRepository _funcionRepository;
        private readonly ITicketsRepository _ticketsRepository;
        private readonly IPeliculasRepository _peliculasRepository;
        private readonly IFuncionValidacion _funcionValidacion;

        public FuncionesService(IGenericRepository repository, IFuncionesRepository funcionRepository, ITicketsRepository ticketsRepository, IPeliculasRepository peliculasRepository)
        {
            _repository = repository;
            _funcionRepository = funcionRepository;
            _ticketsRepository = ticketsRepository;
            _peliculasRepository = peliculasRepository;
            _funcionValidacion = new FuncionesValidation(funcionRepository);
        }

        public IEnumerable<Funciones> Funciones(string fecha , string titulo)
        {
            if (titulo == null)
                return FuncionesPorFecha(fecha);
            else if (!_peliculasRepository.ExistePelicula(titulo))
                return null;
            else
                return FuncionesPorFechaYTitulo(fecha, titulo);
        }

        public IEnumerable<Funciones> FuncionesPorFechaYTitulo(string fecha, string titulo)
        {
            DateTime myDate = _funcionValidacion.StringToFecha(fecha);
            return _funcionRepository.Funciones(myDate, titulo);
        }

        public IEnumerable<Funciones> FuncionesPorFecha(string fecha)
        {
            DateTime myDate = _funcionValidacion.StringToFecha(fecha);
            return _funcionRepository.FuncionesPorFecha(myDate);
        }

        public void EliminarFuncion(int funcionId)
        {
           _repository.DeleteById<Funciones>(funcionId);
        }

        public Funciones FuncionPorId(int funcionId)
        {
            return _repository.GetById<Funciones>(funcionId);
        }

        public Funciones CrearFuncion(FuncionesDto funcion)
        {
            var entidad = new Funciones
            {
                PeliculaId = funcion.PeliculaId,
                SalaId = funcion.SalaId,
                Fecha = Convert.ToDateTime(funcion.Fecha),
                Horario = TimeSpan.Parse(funcion.Horario)
            }; 
            if (_funcionValidacion.SePuedeCrearFuncion(entidad))
            {
                _repository.Add(entidad);
                return entidad;
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<Funciones> FuncionesDePelicula(int peliculaId)
        {
            return _funcionRepository.FuncionesDePelicula(peliculaId);
        }

        public bool ExisteFuncion(int funcionId)
        {
            return _funcionRepository.ExisteFuncion(funcionId);
        }

        public int CantidadTicketsDisponibles (int funcionId)
        {
            return _ticketsRepository.CantidadTicketsDisponibles(funcionId);
        }

    }
}
