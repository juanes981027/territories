using FunctionApp4.Domain.Interfaces;
using FunctionApp4.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionApp4.Infrastructure.Context;
using FunctionApp4.Domain.Models;

namespace FunctionApp4.Application.Services
{
    public class TerritoriesService
    {
        //  private readonly ITerritoriesRepository _territoriesRepository;
        
        // public TerritoriesService (ITerritoriesRepository territoriesRepository)
        // {
        //     _territoriesRepository = territoriesRepository;
        // }
        // public async Task<Territory> AddPreachingInfo()
        // {
        //     return await _territoriesRepository.AddPreachingInfo();
        // }

        public List<Territory> GetTerritories ()
        {
            TerritoriesDB territoriesDb = new TerritoriesDB();
            List<Territory> territories = territoriesDb.Get();

            return territories;

            
        }
    }
 }
