using FunctionApp4.Application.Services;
using FunctionApp4.Domain.Interfaces;
using FunctionApp4.Infrastructure.Context;
using FunctionApp4.Infrastructure.Repositories;
using Microsoft.Azure.Functions.Worker;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Data;
using System.Data.SqlClient;

var host = new HostBuilder()
    .ConfigureFunctionsWebApplication()
    .ConfigureServices((context, services) =>
    {
        services.AddApplicationInsightsTelemetryWorkerService();
        services.ConfigureFunctionsApplicationInsights();

        var configuration = context.Configuration;
        var connectionString = configuration.GetConnectionString("Connection");
        // services.AddTransient<IDbConnection>(sp => new SqlConnection(connectionString));

        //registrar servicio para la conexion
        // services.AddDbContext<AppDbContext>(
        //     options => options.UseSqlServer(connectionString)
        //     );

        services.AddSingleton<FunctionApp4Service>();
        services.AddSingleton<CellphoneService>();
        services.AddSingleton<MailValidator>();
        services.AddSingleton<InformePredicacionService>();
        services.AddSingleton<IInformePredicacionRepository, InformePredicacionRepository>();
        services.AddSingleton<ICellphoneRepository, CellphoneRepository>();
        // services.AddSingleton<TerritoriesService>();
        
    
    })
    .Build();

host.Run();
