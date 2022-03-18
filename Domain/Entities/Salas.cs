using System.Collections.Generic;

namespace Domain.Entities
{
    public class Salas
    {
        public int SalaId { set; get; }
        public int Capacidad { set; get; }
        public ICollection<Funciones> Funciones { set; get; }
        public Salas()
        {
            Funciones = new HashSet<Funciones>();
        }
    }
}
