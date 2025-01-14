using System.Text.Json.Serialization;
using BusinessLayer.Catalog;
using BusinessObjects.Entity;
using DataAccessLayer.Contexts;
using DataAccessLayer.Repository;
using Microsoft.EntityFrameworkCore;
using Services.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(x => 
  x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles); 
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICatalogManager, CatalogManager>();
builder.Services.AddScoped<ICatalogService, CatalogService>();
builder.Services.AddScoped<IGenericRepository<Author>, AuthorRepository>();
builder.Services.AddScoped<IGenericRepository<Book>, BookRepository>();
builder.Services.AddScoped<IGenericRepository<Library>, LibraryRepository>();
                
builder.Services.AddDbContext<LibraryContext>(options => 
  options.UseSqlite("Data Source=/Users/clem/Developer/code/biblioteca/ressources/library.db;")
);

/*
Les Middleware ajoutés avant le builder seront récupérer par l'application
*/

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