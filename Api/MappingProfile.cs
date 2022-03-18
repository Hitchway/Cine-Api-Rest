using AutoMapper;
using Domain.DTOs;
using Domain.Entities;

namespace Api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Peliculas, PeliculasDto>();
            CreateMap<Peliculas, PeliculasDtoConId>();
            CreateMap<Funciones, FuncionesDto>()
                .ForMember(FuncionDto => FuncionDto.Fecha,opt=>opt.MapFrom(src=>src.Fecha.ToString("yyyy-MM-dd")))
                .ForMember(FuncionDto => FuncionDto.Horario, opt => opt.MapFrom(src => src.Horario.ToString(@"hh\:mm")));
            CreateMap<Funciones, FuncionesDtoConId>()
                .ForMember(FuncionDto => FuncionDto.Fecha, opt => opt.MapFrom(src => src.Fecha.ToString("yyyy-MM-dd")))
                .ForMember(FuncionDto => FuncionDto.Horario, opt => opt.MapFrom(src => src.Horario.ToString(@"hh\:mm")));
            CreateMap<Salas, SalasDto>();
            CreateMap<Tickets, TicketsDto>();
            CreateMap<Tickets, TicketsDtoRespuesta>();
        }
    }
}
