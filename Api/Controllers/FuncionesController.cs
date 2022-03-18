using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Application.Services;
using Domain.DTOs;
using AutoMapper;
using System.Text.Json;
using Domain.Errores;

namespace Api.Controllers
{
    [Route("api/funcion")]
    [ApiController]
    public class FuncionesController : ControllerBase
    {
        private readonly IFuncionesService _serviceFunciones;
        private readonly IPeliculasService _servicePeli;
        private readonly ISalasService _serviceSalas;
        private readonly IMapper _mapper;

        public FuncionesController(IFuncionesService serviceFunciones,IPeliculasService servicePeli, ISalasService serviceSalas, IMapper mapper)
        {
            _serviceFunciones = serviceFunciones;
            _servicePeli = servicePeli;
            _serviceSalas = serviceSalas;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<FuncionesDtoConId>), StatusCodes.Status200OK)]
        public IActionResult GetFunciones(string fecha = null, string titulo = null)
        {
            try
            {
                var funcionPorTitulo = _serviceFunciones.Funciones(fecha, titulo);
                var funcionResultado = _mapper.Map<IEnumerable<FuncionesDtoConId>>(funcionPorTitulo);
                if (funcionPorTitulo == null)
                {
                    return new JsonResult(new FuncionesErrorTitle(titulo));
                }
                if (!funcionResultado.Any())
                {
                    return new JsonResult(new FuncionesNotFound());
                }
                return Ok(funcionResultado);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("pelicula/{peliculaId:int}")]
        [ProducesResponseType(typeof(IEnumerable<FuncionesDto>), StatusCodes.Status200OK)]
        public IActionResult FuncionesDePelicula(int peliculaId)
        {
            try
            {
                if (!_servicePeli.ExistePelicula(peliculaId))
                {
                    return NotFound($"La pelicula con ID = {peliculaId} NO existe.");
                }
                var funciones = _serviceFunciones.FuncionesDePelicula(peliculaId);
                var funcionResultado = _mapper.Map<IEnumerable<FuncionesDto>>(funciones);
                if (funcionResultado.Any())
                    return Ok(funcionResultado);
                else
                    return NotFound($"La pelicula con ID = {peliculaId} NO tiene funciones actualmente.");
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(FuncionesDtoConId), StatusCodes.Status200OK)]
        public IActionResult FuncionPorId(int id)
        {
            try
            {
                if (!_serviceFunciones.ExisteFuncion(id))
                {
                    return new JsonResult(new FuncionesNotFound());
                }
                var funciones = _serviceFunciones.FuncionPorId(id);
                var funcionResultado = _mapper.Map<FuncionesDtoConId>(funciones);
                return Ok(funcionResultado);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost]
        [ProducesResponseType(typeof(FuncionesDtoConId), StatusCodes.Status201Created)]
        public IActionResult Post(FuncionesDto funcion)
        {
            try
            {
                if (_servicePeli.ExistePelicula(funcion.PeliculaId))
                {
                    if (_serviceSalas.ExisteSala(funcion.SalaId))
                    {
                        var fun = _serviceFunciones.CrearFuncion(funcion);
                        var funResultado = _mapper.Map<FuncionesDtoConId>(fun);
                        if (funResultado != null)
                        {
                            return Ok(funResultado);
                        }
                        else
                        {
                            return UnprocessableEntity(new FuncionesErrorSuperposicion());
                        }
                    }
                    else
                    {
                        return new JsonResult(new SalaNotFound());
                    }
                }
                else 
                {
                    return new JsonResult(new PeliculaNotFound());
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        

        [HttpDelete("{id:int}")]
        [ProducesResponseType(typeof(FuncionesDtoConId), StatusCodes.Status200OK)]
        public IActionResult DeleteFuncion(int id)
        {
            try
            {
                var funcionAEliminar = _serviceFunciones.FuncionPorId(id);
                var funcionResultado = _mapper.Map<FuncionesDtoConId>(funcionAEliminar);
                if (funcionAEliminar == null)
                {
                    return NotFound($"La funcion con ID = {id} NO se encuentra.");
                }
                _serviceFunciones.EliminarFuncion(id);
                return Ok(funcionResultado);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error interno del servidor al eliminar una funcion.");
            }
        }

        [HttpGet("{id:int}/tickets")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public IActionResult CantidadDeTicketsDisponibles(int id)
        {
            try
            {
                if (!_serviceFunciones.ExisteFuncion(id))
                    return NotFound($"La funcion con ID = {id} NO se encuentra.");
                else
                    return Ok(_serviceFunciones.CantidadTicketsDisponibles(id));
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
