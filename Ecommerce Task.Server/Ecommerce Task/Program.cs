using Ecommerce_Task.Repositories;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<ISiteRepository, SiteRepository>();
builder.Services.AddControllers().AddJsonOptions(options =>
options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault);
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddCors(setup =>
{
    setup.AddPolicy("CorsPolicy", options =>
    {
        options.AllowAnyMethod().AllowAnyHeader()
        .AllowAnyOrigin().WithOrigins(builder.Configuration["Cors:LocalHost"]);
    });
});

builder.Services.AddSwaggerGen(setupAction: swaggerGenOptions =>
{
    swaggerGenOptions.SwaggerDoc(name: "v1", info: new OpenApiInfo
    {

        Title = "Sites",
        Version = "v1",
        Description = "An API for displaying sites",
        Contact = new OpenApiContact
        {
            Name = "Daniel Razal",
            Email = "mr.danielrazal@gmail.com",
            Url = new Uri("https://www.linkedin.com/in/daniel-razal/"),
        },
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(setupAction: swaggerUIOptions =>
    {
        swaggerUIOptions.DocumentTitle = "ASP .NET Sites";
        swaggerUIOptions.SwaggerEndpoint(url: "/swagger/v1/swagger.json", name: "WEB API serving a very simple Site model");
        swaggerUIOptions.RoutePrefix = string.Empty;

    });
}

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
