using CIPMApplication.Data;
using Microsoft.EntityFrameworkCore;
using CIPMApplication.Controllers;
using CIPMApplication.Migrations;
using CIPMApplication.Repo.Interface;
using CIPMApplication.Repo.Repo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//
string connectionstring = builder.Configuration.GetConnectionString("connectionstring");
builder.Services.AddDbContext<ApplicationDbContext>(o => o.UseSqlServer(connectionstring));

builder.Services.AddScoped<IStudentRepo, StudentsRepo>();

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

app.MapStudentsEndpoints();

app.Run();
