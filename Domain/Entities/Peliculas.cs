using System.Collections.Generic;

namespace Domain.Entities
{
    public class Peliculas
    {
        public int PeliculaId { set; get; }
        public string Titulo { set; get; }
        public string Sinopsis { set; get; }
        public string Poster { set; get; }
        public string Trailer { set; get; }
        public ICollection<Funciones> Funciones { set; get; }
        public Peliculas()
        {
            Funciones = new HashSet<Funciones>();
        }
        
    }
}
