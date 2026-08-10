using AuthenticationService.API.Configuration;
using AuthenticationService.API.Services;
using Microsoft.Extensions.Options;
using System.Security.Cryptography;

var builder = WebApplication.CreateBuilder(args);

// =====================================================
// Options Pattern Configuration
// =====================================================

builder.Services
    .AddOptions<JwtSettings>()
    .Bind(builder.Configuration.GetSection("JwtSettings"))
    .ValidateDataAnnotations()
    .ValidateOnStart();

builder.Services
    .AddOptions<DatabaseSettings>()
    .Bind(builder.Configuration.GetSection("ConnectionStrings"))
    .ValidateDataAnnotations()
    .ValidateOnStart();

builder.Services
    .AddOptions<SmsSettings>()
    .Bind(builder.Configuration.GetSection("SmsSettings"))
    .ValidateDataAnnotations()
    .ValidateOnStart();

builder.Services
    .AddOptions<SerilogSettings>()
    .Bind(builder.Configuration.GetSection("Serilog"))
    .ValidateDataAnnotations()
    .ValidateOnStart();

builder.Services
    .AddOptions<SwaggerSettings>()
    .Bind(builder.Configuration.GetSection("SwaggerSettings"))
    .ValidateDataAnnotations()
    .ValidateOnStart();

builder.Services
    .AddOptions<ApplicationSettings>()
    .Bind(builder.Configuration.GetSection("ApplicationSettings"))
    .ValidateDataAnnotations()
    .ValidateOnStart();
builder.Services.AddControllers();

builder.Services.AddScoped<IConfigurationTestService, ConfigurationTestService>();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();