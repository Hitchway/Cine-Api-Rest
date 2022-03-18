using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class FuncionesNotFound
    {
        public string Message { get; set; }
        public string Status { get; set; }

        public FuncionesNotFound()
        {
            Message = "Lamentablemente no se encontraron funciones para lo solicitado";
            Status = "Error 404";
        }
    }
}
