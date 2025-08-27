using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacheConsole.Config
{
    public class Settings
    {
        public string DbConnectionString { get; set; }
        public string DbConnectionStringTest { get; set; }

        public string GetDbString()
        {
            string ConnectionString;
            IConfigurationRoot config = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .AddEnvironmentVariables()
                    .Build();

            var SettingInfoDb = config.GetSection("Settings").Get<Settings>();

            if(Environment.GetEnvironmentVariable("app") != "console")
            {
                ConnectionString = SettingInfoDb.DbConnectionStringTest;
            }
            else
            {
                ConnectionString = SettingInfoDb.DbConnectionString;
            }

            return ConnectionString;
        }
    }
}
