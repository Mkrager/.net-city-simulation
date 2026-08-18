using CitySimulation.Api;
using CitySimulation.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var app = builder
    .ConfigureService()
    .ConfigurePipeline();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider
    .GetRequiredService<CitySimulationDbContext>();

    await context.Database.EnsureDeletedAsync();
    await context.Database.MigrateAsync();
}

    app.Run();
// public partial class Program { }