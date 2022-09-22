using Triangular.Business.Interfaces;
using Triangular.Business.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IGridReferenceService, GridReferenceService>();
builder.Services.AddScoped<ITriangleServiceFactory, TriangleServiceFactory>();
builder.Services.AddScoped<ITriangleByGridReferenceService, TriangleByGridReferenceService>();

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
