using Domain.Commands;
using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Application.Validation
{
    public interface IFuncionValidacion
    {
        bool SePuedeCrearFuncion(Funciones funcion);
        DateTime StringToFecha(string fecha);
    }
    public class FuncionesValidation : IFuncionValidacion
    {
        private readonly IFuncionesRepository _repositoryFunciones;
        public FuncionesValidation(IFuncionesRepository repositoryFunciones)
        {
            _repositoryFunciones = repositoryFunciones;
        }
        public DateTime StringToFecha(string fecha)
        {
            if (fecha!=null)
            {
                return DateTime.ParseExact(fecha, "yyyy-MM-dd",
                                       System.Globalization.CultureInfo.InvariantCulture);
            }
            else
            {
                return DateTime.Now.Date;
            }
        }
        public bool SePuedeCrearFuncion(Funciones funcion)
        {
            IEnumerable<Funciones> funciones = _repositoryFunciones.FuncionesPorFechaYSala(funcion.Fecha, funcion.SalaId);

            foreach (var fun in funciones)
            {
                if ((funcion.Horario - fun.Horario).Duration() < new TimeSpan(2, 30, 0))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
