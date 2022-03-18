using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Commands
{
    public interface ITicketsRepository
    {
        List<Tickets> ListaTicketsPorFuncion(int funcionId);
        int CantidadTicketsDisponibles(int funcionId);
    }
}
