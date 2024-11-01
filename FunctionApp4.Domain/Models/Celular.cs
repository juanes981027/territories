using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp4.Domain.Models
{
    public class Celular: CellphoneBattery
    {
        public Celular(int batteryPercentage) {
            this.Status = batteryPercentage;
        }
        public string Brand { get; set; }

        public int Year { get; set; }


    }
}
