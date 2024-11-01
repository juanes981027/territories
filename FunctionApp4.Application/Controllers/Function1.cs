using FunctionApp4.Application.Services;
using FunctionApp4.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using AuthorizationLevel = Microsoft.Azure.Functions.Worker.AuthorizationLevel;
using HttpTriggerAttribute = Microsoft.Azure.Functions.Worker.HttpTriggerAttribute;
using FunctionApp4.Domain.Models;

namespace FunctionApp4.Application.Controllers
{
    public class Function1
    {
        private readonly ILogger<Function1> _logger;
        private readonly CellphoneService _cellphoneService;
        private readonly FunctionApp4Service _functionApp4Service;
        private readonly MailValidator _mailValidator;
        private readonly InformePredicacionService _informePredicacion;
        private readonly TerritoriesService _territoriesService;

        public Function1(ILogger<Function1> logger, CellphoneService cellphoneService, FunctionApp4Service functionApp4Service, MailValidator mailValidator, InformePredicacionService informePredicacion, TerritoriesService territoriesService)
        {
            _cellphoneService = cellphoneService;
            _logger = logger;
            _functionApp4Service = functionApp4Service;
            _mailValidator = mailValidator;
            _informePredicacion = informePredicacion;
            _territoriesService = territoriesService;

        }   

        [Function("Function1")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");


            return new OkObjectResult(await _functionApp4Service.GetEmployees());
        }
        [Function("GetInfoEmployee")]


        public async Task<IActionResult> GetInfoEmployee([HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequest req)
        {

            return new OkObjectResult(await _functionApp4Service.GetEmployees());
        }

        [Function("ChargeBattery")]
        public async Task<ActionResult> ChargeBattery([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequest req)
        {

            return new OkObjectResult(await _cellphoneService.ChargeBattery());

        }

        [Function("DepleteBattery")]
        public async Task<ActionResult> DepleteBattery([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequest req)
        {
            return new OkObjectResult(await _cellphoneService.DepleteBattery());
        }

        [Function("IsSpam")]
        public async Task<ActionResult<bool>> IsSpam([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequest req)
        {
            return new OkObjectResult(_mailValidator.IsSpam("juan.rodriguezc"));
        }
        [Function("InformePredicacion")]
        public async Task<ActionResult<object>> InformePredicacion([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequest req)
        {
            
            return new OkObjectResult(_informePredicacion.InformeMes() );
        }

        // public async Task<ActionResult<Territory>> AddPreachingInfo([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequest req)
        // {
        //     return new OkObjectResult(_territoriesService.AddPreachingInfo());
        // }

        [Function("ObtenerListaTerritorios")]
        public async Task<ActionResult<Territory>> GetTerritories ([HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequest req)
        {
            TerritoriesService ts = new TerritoriesService();
            var territories = ts.GetTerritories();
            return new OkObjectResult(territories);
        }
    }
}
