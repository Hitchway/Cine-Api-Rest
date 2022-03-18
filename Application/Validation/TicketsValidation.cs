using Domain.Commands;
using Domain.Entities;

namespace Application.Validation
{
    public interface ITicketsValidation
    {
        bool SePuedenCrearTickets(int cantidad, int funcionId);
    }
    public class TicketsValidation : ITicketsValidation
    {
        private readonly ITicketsRepository _ticketsRepository;
        private readonly IGenericRepository _repository;
        public TicketsValidation(IGenericRepository repository,  ITicketsRepository ticketsRepository)
        {
            _repository = repository;
            _ticketsRepository = ticketsRepository;
        }
        public bool SePuedenCrearTickets(int cantidad,int funcionId)
        {
            if (cantidad > 0)
            {
                var funcion = _repository.GetById<Funciones>(funcionId);
                var listaTicketsDeFuncion = _ticketsRepository.ListaTicketsPorFuncion(funcionId);
                var sala = _repository.GetById<Salas>(funcion.SalaId);
                return ((sala.Capacidad - listaTicketsDeFuncion.Count) >= cantidad);
            }
            else
            {
                return false;
            }
        }
    }
}
