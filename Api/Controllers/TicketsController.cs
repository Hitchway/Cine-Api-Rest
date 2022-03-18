using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Application.Services;
using Domain.DTOs;
using AutoMapper;
using System.Collections.Generic;
using Domain.Errores;

namespace Api.Controllers
{
    [Route("api/ticket")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketsService _service;
        private readonly IFuncionesService _funcionesService;
        private readonly IMapper _mapper;

        public TicketsController(ITicketsService service, IMapper mapper, IFuncionesService funcionesService)
        {
            _service = service;
            _funcionesService = funcionesService;
            _mapper = mapper;
        }

        [HttpPost]
        [ProducesResponseType(typeof(IEnumerable<TicketsDtoRespuesta>), StatusCodes.Status201Created)]
        public IActionResult Post(TicketsDto ticket)
        {
            try
            {
                if (!_funcionesService.ExisteFuncion(ticket.FuncionId))
                {
                    return NotFound(new FuncionesNotFound());
                }
                if (ticket.Cantidad<=0)
                {
                    return StatusCode(400, "Se debe ingresar una cantidad de tickets mayores a 0");
                }
                
                var tick = _service.CrearTickets(ticket);
                var tickResultado = _mapper.Map<IEnumerable<TicketsDtoRespuesta>>(tick);
                
                if (tick != null)
                {
                    return new JsonResult(tickResultado);
                }
                else
                    return new JsonResult(new TicketsErrorCapacidad());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
