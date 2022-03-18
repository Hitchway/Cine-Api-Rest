using System.Collections.Generic;
using System.Linq;
using Domain.Commands;
using Domain.Entities;

namespace AccessData.Commands
{
    public class TicketsRepository: ITicketsRepository
    {
        private readonly CineContext _context;
        public TicketsRepository(CineContext context)
        {
            _context = context;
        }

        public List<Tickets> ListaTicketsPorFuncion(int funcionId)
        {
            return _context.Tickets.Where(s => s.FuncionId == funcionId).ToList();
        }

        public int CantidadTicketsDisponibles(int funcionId)
        {
            var fun = _context.Funciones.Find(funcionId);
            var sala = _context.Salas.Find(fun.SalaId);
            return sala.Capacidad - _context.Tickets.Where(x => x.FuncionId == fun.FuncionId).Count();
        }
    }
}