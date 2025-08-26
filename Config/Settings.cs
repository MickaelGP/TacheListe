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
            IConfigurationRoot config = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .AddEnvironmentVariables()
                    .Build();
            var SettingInfoDb = config.GetSection("Settings").Get<Settings>();

            string ConnectionString = SettingInfoDb.DbConnectionString;

            return ConnectionString;
        }

        public string GetDbStringTest()
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .AddEnvironmentVariables()
                    .Build();
            var SettingInfoDb = config.GetSection("SettingsTest").Get<Settings>();

            string ConnectionString = SettingInfoDb.DbConnectionStringTest;

            return ConnectionString;
        }
    }
}
