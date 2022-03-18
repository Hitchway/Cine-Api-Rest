using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Errores
{
    public class FormatoErrorCantidad
    {
        public string Message { get; set; }
        public string Status { get; set; }

        public FormatoErrorCantidad()
        {
            Message = "Error de formato. La cantidad debe ser numerica";
            Status = "Error 400";
        }
    }
}
