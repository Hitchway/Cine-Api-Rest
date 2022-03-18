using Application.Validation;
using Domain.Commands;
using Domain.DTOs;
using Domain.Entities;
using System.Collections.Generic;

namespace Application.Services
{
    public interface ITicketsService
    {
        List<Tickets> CrearTickets(TicketsDto ticket);
        int CantidadTicketsDisponibles(int funcionId);
    }
    public class TicketsService : ITicketsService
    {
        private readonly ITicketsValidation _ticketValidation;
        private readonly ITicketsRepository _ticketsRepository;
        private readonly IGenericRepository _repository;

        public TicketsService(IGenericRepository repository, ITicketsRepository ticketsRepository)
        {
            _repository = repository;
            _ticketsRepository = ticketsRepository;
            _ticketValidation = new TicketsValidation(_repository, _ticketsRepository);
        }

        public int CantidadTicketsDisponibles(int funcionId)
        {
            return _ticketsRepository.CantidadTicketsDisponibles(funcionId);
        }

        public List<Tickets> CrearTickets(TicketsDto ticket)
        {
            Tickets entidad = null;
            List<Tickets> ticketsGenerados = new();
            if (_ticketValidation.SePuedenCrearTickets(ticket.Cantidad, ticket.FuncionId))
            {
                for (int i = 0; i < ticket.Cantidad; i++)
                {
                    entidad = new Tickets
                    {
                        TicketId = new System.Guid(),
                        FuncionId = ticket.FuncionId,
                        Usuario = ticket.Usuario
                    };
                    ticketsGenerados.Add(entidad);
                    _repository.Add<Tickets>(entidad);
                }
            }
            if (ticketsGenerados.Count>0)
            {
                return ticketsGenerados;
            }
            else
            {
                return null;
            }
            
        }
    }
}
