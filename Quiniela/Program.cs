using Microsoft.EntityFrameworkCore;
using Quiniela.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<SedeContext>(opt =>
    opt.UseInMemoryDatabase("Quiniela"));
builder.Services.AddDbContext<EquipoContext>(opt =>
    opt.UseInMemoryDatabase("Quiniela"));
builder.Services.AddDbContext<GrupoContext>(opt =>
    opt.UseInMemoryDatabase("Quiniela"));
builder.Services.AddDbContext<EstadioContext>(opt =>
    opt.UseInMemoryDatabase("Quiniela"));
builder.Services.AddDbContext<JornadaContext>(opt =>
    opt.UseInMemoryDatabase("Quiniela"));
builder.Services.AddDbContext<EventoContext>(opt =>
    opt.UseInMemoryDatabase("Quiniela"));
builder.Services.AddDbContext<PronosticoContext>(opt =>
    opt.UseInMemoryDatabase("Quiniela"));
//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v1", new() { Title = "TodoApi", Version = "v1" });
//});
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
