using Generic_Repo_Pattern_Demo.Base;
using Generic_Repo_Pattern_Demo.Base.Interfaces;
using Generic_Repo_Pattern_Demo.Context;
using Generic_Repo_Pattern_Demo.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Xml.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(
    opts =>
    {
        opts.EnableSensitiveDataLogging();
        opts.EnableDetailedErrors();
        opts.UseNpgsql(builder.Configuration.GetConnectionString("Db_Connection"));
    },
    ServiceLifetime.Transient
);

builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IController<>), typeof(GenericController<>));

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
