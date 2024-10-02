using GeekShopping.ProductAPI.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddApiConfiguration(builder.Configuration);
builder.Services.AddSwaggerConfiguration(builder.Configuration);
builder.Services.AddDependencyInjectionConfiguration(builder.Configuration);

var app = builder.Build();

app.UseSwaggerConfiguration(app.Environment);
app.UseApiConfiguration(app.Environment);

app.Run();
