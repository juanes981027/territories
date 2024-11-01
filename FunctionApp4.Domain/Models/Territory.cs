using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp4.Domain.Models
{
    public class Territory
    {
        public int Id { get; set; }

        public string TerritoryName { get; set; }
        
        public string TerritoryNumber { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

    }
}
