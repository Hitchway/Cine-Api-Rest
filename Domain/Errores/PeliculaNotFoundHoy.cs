using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Errores
{
    public class PeliculaNotFoundHoy
    {
        public string Message { get; set; }
        public string Status { get; set; }

        public PeliculaNotFoundHoy()
        {
            Message = "Lamentablemente hoy no hay funciones programadas de ninguna pelicula";
            Status = "Error 422";
        }
    }
}