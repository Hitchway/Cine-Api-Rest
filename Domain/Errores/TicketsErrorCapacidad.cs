using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Errores
{
    public class TicketsErrorCapacidad
    {
        public string Message { get; set; }
        public string Status { get; set; }

        public TicketsErrorCapacidad()
        {
            Message = "No hay capacidad suficiente en la funcion";
            Status = "Error 422";
        }
    }
}
