using FunctionApp4.Domain.Interfaces;
using FunctionApp4.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp4.Infrastructure.Repositories
{
    public class CellphoneRepository : ICellphoneRepository
    {
        public async Task<int> ChargeBattery()
        {
            var oCelular = new Celular(99);


            if (oCelular.Status < 100)
            {
                oCelular.BatteryCharge();
            }
            else
            {
                Console.Write("Battery is already at 100%");
            }

            return oCelular.Status;
        }

        public async Task<int> DepleteBattery()
        {
            var oCelular = new Celular(0);

            if (oCelular.Status > 0)
            {
                oCelular.BatteryDepletion();
            }
            else
            {
                Console.WriteLine("Battery is already dead");
            }

            return oCelular.Status;
        }
    }
}
