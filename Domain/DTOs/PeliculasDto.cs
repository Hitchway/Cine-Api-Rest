namespace Domain.DTOs
{
    public class PeliculasDto
    {
        public string Titulo { set; get; }
        public string Poster { set; get; }
        public string Trailer { set; get; }
        public string Sinopsis { set; get; }
    }
    public class PeliculasDtoConId
    {
        public int PeliculaId { set; get; }
        public string Titulo { set; get; }
        public string Poster { set; get; }
        public string Trailer { set; get; }
        public string Sinopsis { set; get; }

    }
}
