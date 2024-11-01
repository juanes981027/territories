using FunctionApp4.Domain.Interfaces;
using FunctionApp4.Domain.Models;

namespace FunctionApp4.Application.Services
{
    public class InformePredicacionService
    {
        private readonly IInformePredicacionRepository _informePredicacionRepository;
        public InformePredicacionService(IInformePredicacionRepository informePredicacionRepository)
        {
            _informePredicacionRepository = informePredicacionRepository;

        }
        
        public async Task<HojaInforme>InformeMes()
        {
            return await _informePredicacionRepository.InformeMes();
            
        }

    }
}
