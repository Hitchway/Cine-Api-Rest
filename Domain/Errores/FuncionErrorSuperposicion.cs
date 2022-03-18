using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Errores
{
    public class FuncionesErrorSuperposicion
    {
        public string Message { get; set; }
        public string Status { get; set; }

        public FuncionesErrorSuperposicion()
        {
            Message = "La funcion se superpone con otra y no se puede almacenar";
            Status = "Error 422";
        }
    }
}
