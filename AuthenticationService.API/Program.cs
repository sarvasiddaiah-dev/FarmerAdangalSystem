using AuthenticationService.API.Configuration;
using AuthenticationService.API.Services;
using AuthenticationService.Application.Extensions;

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

// Application Services
builder.Services.AddApplicationServices();
// MVC / API
builder.Services.AddControllers();
// Authorization
builder.Services.AddAuthorization();
// Configuration Test Service
builder.Services.AddScoped<IConfigurationTestService, ConfigurationTestService>();
// Swagger
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();
// Build Application
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