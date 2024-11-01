using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp4.Domain.Interfaces
{
    public interface ICellphoneRepository
    {
        Task<int> ChargeBattery();
        Task<int> DepleteBattery();
    }
}
