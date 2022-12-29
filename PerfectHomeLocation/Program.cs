using Microsoft.EntityFrameworkCore;
using PerfectHomeLocation.Api.Clients;
using PerfectHomeLocation.Api.Repositories;
using PerfectHomeLocation.Api.Services;
using PerfectHomeLocation.Database.Contexts;
using System.Text.Json.Serialization;

public static class Program
{
    public static void Main(string[] args)
    {
        WebApplication app = WebApplication.CreateBuilder(args)
            .SetupConfiguration()
            .SetupDI()
            .Build()
            .SetupAppPipeline();
        
        app.Run();
    }

    private static WebApplicationBuilder SetupConfiguration(this WebApplicationBuilder builder)
    {
        builder.Configuration.AddJsonFile("secrets.json");
        return builder;
    }

    private static WebApplicationBuilder SetupDI(this WebApplicationBuilder builder)
    {
        var services = builder.Services;

        services.AddControllers()
            .AddJsonOptions(x => x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        //MapsApiClient mapsService = new MapsApiClient(builder.Configuration["secrets:googleApiKey"] ?? "");
        services.AddScoped<IMapsApiClient>(x =>
            new MapsApiClient(builder.Configuration["secrets:googleApiKey"] ?? "", x.GetRequiredService<PerfHomeContext>()));
        services.AddScoped<IMapsService, MapsService>();
        services.AddScoped<IPointOfInterestRepository, PointOfInterestRepository>();

        services.AddDbContext<PerfHomeContext>(
            options => options.UseNpgsql(builder.Configuration["secrets:connectionString"]));


        return builder;
    }

    private static WebApplication SetupAppPipeline(this WebApplication app)
    {
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        return app;
    }
}

