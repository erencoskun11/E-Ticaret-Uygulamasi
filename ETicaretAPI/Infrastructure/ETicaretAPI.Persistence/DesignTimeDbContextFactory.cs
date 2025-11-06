// ETicaretAPI.Persistence/DesignTimeDbContextFactory.cs
using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ETicaretAPI.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ETicaretAPIDbContext>
    {
        public ETicaretAPIDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ETicaretAPIDbContext>();
            string conn = null;

            try
            {
                var config = new ConfigurationManager();
                // Persistence projesinin çalışma dizininden appsettings.json oku (en güvenli)
                config.SetBasePath(Directory.GetCurrentDirectory());
                config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: false);
                conn = config.GetConnectionString("PostgreSQL");
            }
            catch
            {
                // yoksa yut ve fallback'a geç
            }

            if (string.IsNullOrWhiteSpace(conn))
            {
                // kesin fallback: migration için kullanılacak string
                conn = "Host=localhost;Port=5432;Database=ETicaretAPI;Username=postgres;Password=guest";
            }

            optionsBuilder.UseNpgsql(conn);
            return new ETicaretAPIDbContext(optionsBuilder.Options);
        }
    }
}
