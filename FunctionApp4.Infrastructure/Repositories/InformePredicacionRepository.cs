using FunctionApp4.Domain.Interfaces;
using FunctionApp4.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp4.Infrastructure.Repositories
{
    public class InformePredicacionRepository : IInformePredicacionRepository
    {
        public async Task<HojaInforme> InformeMes()
        {

            string name = "Juan";

            string activity = "Yes";

            string month = "July";

            int BibleStudies = 1;

            string Pioneer = "no";

            HojaInforme hojaInforme = new HojaInforme(name, month, activity, BibleStudies, Pioneer);
            hojaInforme.Name = name;
            hojaInforme.Month = month;
            hojaInforme.Activity = activity;
            hojaInforme.BibleStudies = BibleStudies;
            hojaInforme.Pioneer = Pioneer;
            Console.WriteLine(hojaInforme.Pioneer);
            Console.WriteLine("my comment");


            return hojaInforme;

        }

    }
}
