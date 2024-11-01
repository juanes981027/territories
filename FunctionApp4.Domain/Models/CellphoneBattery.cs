using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp4.Domain.Models
{
    public class CellphoneBattery
    {
        public int Milliamps { get; set; }

        public int Status { get; set; } = 100;

        public void BatteryDepletion ()
        {
            this.Status = this.Status - 1;
        }

        public void BatteryCharge()
        {
            this.Status = this.Status + 1;
        }
    }
}
