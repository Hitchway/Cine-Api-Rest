using System;

namespace Domain.DTOs
{
    public class TicketsDto
    {
        public int FuncionId { set; get; }
        public string Usuario { set; get; }
        public int Cantidad { set; get; }
    }
    public class TicketsDtoRespuesta
    {
        public Guid TicketId { set; get; }
        public int FuncionId { set; get; }
        public string Usuario { set; get; }
        public int Cantidad { set; get; }

    }
}
