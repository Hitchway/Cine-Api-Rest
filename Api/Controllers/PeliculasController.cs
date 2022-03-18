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
    [Route("api/pelicula")]
    [ApiController]
    public class PeliculasController : ControllerBase
    {
        private readonly IPeliculasService _service;
        private readonly IMapper _mapper;
        public PeliculasController(IPeliculasService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<PeliculasDto>), StatusCodes.Status200OK)]
        public IActionResult GetListPeliculas()
        {
            try
            {
                var listaPeliculas = _service.ListaPeliculas();
                return Ok(listaPeliculas);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpGet("hoy")]
        [ProducesResponseType(typeof(List<PeliculasDto>), StatusCodes.Status200OK)]
        public IActionResult GetPeliculasDeHoy()
        {
            try
            {
                var listaPeliculas = _service.ListaPeliculasDeHoy();
                if (listaPeliculas.Count>0)
                {
                    return Ok(listaPeliculas);
                }
                else
                {
                    return new JsonResult(new PeliculaNotFoundHoy());
                }
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id?}")]
        [ProducesResponseType(typeof(PeliculasDtoConId), StatusCodes.Status200OK)]
        public IActionResult GetPelicula(int id)
        {
            try
            {
                if (!_service.ExistePelicula(id))
                {
                    return NotFound(new PeliculaNotFound());
                }
                var peliculaPorId = _service.PeliculaPorId(id);
                var peliculaResultado = _mapper.Map<PeliculasDtoConId>(peliculaPorId);
                return Ok(peliculaResultado);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(PeliculasDto), StatusCodes.Status201Created)]
        public IActionResult ActualizarPelicula(PeliculasDto pelicula, int id)
        {
            try
            {
                if(_service.ExistePelicula(id))
                {
                    var peliculaPorId = _service.ActualizarPelicula(pelicula,id);
                    var peliculaResultado = _mapper.Map<PeliculasDto>(peliculaPorId);
                    return Ok(peliculaResultado);
                }
                else
                    return NotFound(new PeliculaNotFound());
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
