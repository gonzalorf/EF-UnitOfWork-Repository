using EF_UnitOfWork_Repository.DataAccess;
using EF_UnitOfWork_Repository.DataAccess.UnitOfWork;
using EF_UnitOfWork_Repository.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// InMemory DB
builder.Services.AddDbContext<PersonContext>(options => options.UseInMemoryDatabase(databaseName: "PersonDB"));

// UoW
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
