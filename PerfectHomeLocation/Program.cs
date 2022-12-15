using PerfectHomeLocation.Clients;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Configuration.AddJsonFile("secrets.json");
MapsApiClient mapsService = new MapsApiClient(builder.Configuration["secrets:googleApiKey"]);
builder.Services.AddSingleton<IMapsApiClient>(mapsService);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
