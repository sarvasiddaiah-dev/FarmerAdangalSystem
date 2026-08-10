using AuthenticationService.API.Configuration;
using System.Security.Cryptography;

var builder = WebApplication.CreateBuilder(args);

// Application Settings
builder.Services
    .AddOptions<ApplicationSettings>()
    .Bind(builder.Configuration.GetSection(ApplicationSettings.SectionName))
    .ValidateDataAnnotations()
    .ValidateOnStart();

// JWT Settings
builder.Services
    .AddOptions<JwtSettings>()
    .Bind(builder.Configuration.GetSection(JwtSettings.SectionName))
    .ValidateDataAnnotations()
    .ValidateOnStart();

// SMS Settings
builder.Services
    .AddOptions<SmsSettings>()
    .Bind(builder.Configuration.GetSection(SmsSettings.SectionName))
    .ValidateDataAnnotations()
    .ValidateOnStart();

// Database
builder.Services.Configure<DatabaseSettings>(
    builder.Configuration.GetSection(DatabaseSettings.SectionName));

// Swagger
builder.Services.Configure<SwaggerSettings>(
    builder.Configuration.GetSection(SwaggerSettings.SectionName));

// Serilog
builder.Services.Configure<SerilogSettings>(
    builder.Configuration.GetSection(SerilogSettings.SectionName));

builder.Services.AddControllers();

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