using Domain.Commands;

namespace Application.Services
{
    public interface ISalasService
    {
        bool ExisteSala(int salaId);
    }
    public class SalasService : ISalasService
    {
        private readonly ISalasRepository _salasRepository;
        public SalasService(ISalasRepository salasRepository)
        {
            _salasRepository = salasRepository;
        }

        public bool ExisteSala(int salaId)
        {
            return _salasRepository.ExisteSala(salaId);
        }
    }
}
