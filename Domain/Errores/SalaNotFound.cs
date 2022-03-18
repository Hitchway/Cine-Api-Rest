using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Errores
{
    public class SalaNotFound
    {
        public string Message { get; set; }
        public string Status { get; set; }

        public SalaNotFound()
        {
            Message = "La sala seleccionada no existe";
            Status = "Error 404";
        }
    }
}
