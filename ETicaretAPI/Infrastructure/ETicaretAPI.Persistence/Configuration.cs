using Microsoft.Extensions.Configuration;
using System.IO;

namespace ETicaretAPI.Persistence
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                var configuration = new ConfigurationManager();

                // appsettings.json dosyasının yolu
                configuration.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ETicaretAPI.API"));
                configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

                // "PostgreSQL" isimli connection string'i döndür
                return configuration.GetConnectionString("PostgreSQL");
            }
        }
    }
}
