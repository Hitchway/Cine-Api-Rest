using System;

namespace Domain.Entities
{
    public class Tickets
    {
        public Guid TicketId { set; get; }
        public int FuncionId { set; get; }
        public virtual Funciones Funcion { set; get; }
        public string Usuario { set; get; }
    }
}
