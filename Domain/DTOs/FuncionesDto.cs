using Domain.Entities;

namespace Domain.DTOs
{
    public class FuncionesDto
    {
        public int PeliculaId { set; get; }
        public int SalaId { set; get; }
        public string Fecha { set; get; }
        public string Horario { set; get; }
    }
    public class FuncionesDtoConId
    {
        public int FuncionId { set; get; }
        public int PeliculaId { set; get; }
        public int SalaId { set; get; }
        public string Fecha { set; get; }
        public string Horario { set; get; }
    }
}
