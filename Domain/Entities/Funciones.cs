using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Funciones
    {
        public int FuncionId { set; get; }
        public int PeliculaId { set; get; }
        public int SalaId { set; get; }
        public DateTime Fecha { set; get; }
        public TimeSpan Horario { set; get; }
        public virtual ICollection<Tickets> Tickets{ set; get; }
        public virtual Peliculas Pelicula { set; get; }
        public virtual Salas Sala { set; get; }
        public Funciones()
        {
            Tickets = new HashSet<Tickets>();
        }
    }
}