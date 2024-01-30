using System.Runtime.CompilerServices;
using BusinessLayer.Catalog;
using BusinessObjects.Entity;
using DataAccessLayer.Contexts;
using DataAccessLayer.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        var config = new ConfigurationBuilder();
        var host = CreateHostBuilder(config);

        var catalogService = host.Services.GetRequiredService<ICatalogService>();
        
        Console.WriteLine(catalogService.ShowCatalog());
    }

    private static IHost CreateHostBuilder(IConfigurationBuilder configuration)
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                // Configuration des services
                services.AddScoped<ICatalogManager, CatalogManager>();
                services.AddScoped<ICatalogService, CatalogService>();
                services.AddScoped<IGenericRepository<Author>, AuthorRepository>();
                services.AddScoped<IGenericRepository<Book>, BookRepository>();
                services.AddScoped<IGenericRepository<Library>, LibraryRepository>();
                
                services.AddDbContext<LibraryContext>(options => 
                    options.UseSqlite("Data Source={../ressources/library.db};")
                );
            })
            .Build();
    }
}