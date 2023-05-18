using Microsoft.EntityFrameworkCore;
using WebApi1.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<QlbanVaLiContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("QlbanVaLiContext")));

builder.Services.AddCors(p => p.AddPolicy("QlibanVaLi", build =>
{
    build.WithOrigins("https://localhost:7095", "https://localhost:7186");
    build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("QlbanVaLiContext");

app.MapControllers();

app.Run();
