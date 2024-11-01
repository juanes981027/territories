using FunctionApp4.Domain.Interfaces;
using FunctionApp4.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp4.Infrastructure.Repositories
{
    public class TerritoriesRepository : ITerritoriesRepository
    {
        Territory territory = new Territory();
        public async Task<Territory> AddPreachingInfo(string territoryNumber, string territoryName, DateTime territoryEndDate, DateTime territoryStartDate)
        {
            

            territory.TerritoryNumber = territoryNumber;
            territory.TerritoryName = territoryName;

            return territory;
        }
    }
}
