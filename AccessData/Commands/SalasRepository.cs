using System.Linq;
using Domain.Commands;

namespace AccessData.Commands
{
    public class SalasRepository: ISalasRepository
    {
        private readonly CineContext _context;
        public SalasRepository(CineContext context)
        {
            _context = context;
        }
        public bool ExisteSala(int salaId)
        {
            return (_context.Salas.Where(x => x.SalaId == salaId).Any());
        }
    }
}
