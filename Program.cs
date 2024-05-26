using dotnet_rest_api_configuration.Extension.Options;
using dotnet_rest_api_configuration.Extension.Configuration.AddRouting;
using dotnet_rest_api_configuration.Extension.Registration.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRoutingConfigurations();
builder.Services.AddControllers();
builder.Services.AddScopedServices();
builder.Services.AddOptionsConfiguration(builder.Configuration);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
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
