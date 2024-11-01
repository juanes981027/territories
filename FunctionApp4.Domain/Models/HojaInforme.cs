using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp4.Domain.Models
{
    public class HojaInforme
    {
        public string Name { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string Activity { get; set; }
        public int BibleStudies { get; set; }
        public string Pioneer { get; set; }
        public string Comments { get; set; }
        public HojaInforme() { }
        public HojaInforme(string Name, string Month, string Activity) { }
        public HojaInforme(string Name, string Month, string Activity, int BibleStudies, string Pioneer) { }
    }
}
