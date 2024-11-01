using FunctionApp4.Domain.Interfaces;
using FunctionApp4.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp4.Application.Services
{
    public class CellphoneService
    {
        private readonly ICellphoneRepository _cellphoneRepository;
        public CellphoneService (ICellphoneRepository cellphoneRepository) {
        
            _cellphoneRepository = cellphoneRepository;
        }
        public async Task<int> ChargeBattery( )
        {
            return await _cellphoneRepository.ChargeBattery();
            
        }
        public async Task<int> DepleteBattery()
        {
            return await _cellphoneRepository.DepleteBattery();

        }

    }
}
