using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Errores
{
    public class PeliculaNotFound
    {
        public string Message { get; set; }
        public string Status { get; set; }

        public PeliculaNotFound()
        {
            Message = "La pelicula seleccionada no existe";
            Status = "Error 404";
        }
    }
}