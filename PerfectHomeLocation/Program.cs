using Microsoft.EntityFrameworkCore;
using PerfectHomeLocation.Clients;
using PerfectHomeLocation.Database;

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

        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        //MapsApiClient mapsService = new MapsApiClient(builder.Configuration["secrets:googleApiKey"] ?? "");
        services.AddScoped<IMapsApiClient>(x =>
            new MapsApiClient(builder.Configuration["secrets:googleApiKey"] ?? "", x.GetRequiredService<PerfHomeContext>()));

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

