using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CampusLove.src.shared.context;

using Microsoft.Extensions.Configuration;


namespace CampusLove.src.shared.configurations;

public class AppDbContextFactory
{
    public static AppDbContext Create()
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true)
            .AddEnvironmentVariables()
            .Build();

        string? connectionString = Environment.GetEnvironmentVariable("MYSQL_CONNECTION")
            ?? config.GetConnectionString("MySqlDB");
        if (string.IsNullOrWhiteSpace(connectionString))
            throw new InvalidOperationException("No se encontró una cadena de conexión válida.");
        var options = new DbContextOptionsBuilder<AppDbContext>()
        .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
        .Options;
        return new AppDbContext(options);
        }
    }
