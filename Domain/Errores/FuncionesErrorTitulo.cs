using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class FuncionesErrorTitle
    {
        public string Message { get; set; }
        public string Status { get; set; }

        public FuncionesErrorTitle(string title)
        {
            Message = "La pelicula "+title+" no existe";
            Status = "Error 404";
        }
    }
}
