using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TacheConsole.Config;

namespace TacheConsole
{
    public abstract class Connexion
    {
        private readonly string ConnexionString;

        protected SqlConnection? _connexion;

        private  Settings _settings = new Settings();

        public Connexion()
        {
            if (Environment.GetEnvironmentVariable("app") != "console")
            {
                ConnexionString = _settings.GetDbStringTest();
            }
            else
            {
                ConnexionString = _settings.GetDbString();

            }
        }

        protected void DbConnecter()
        {
            if (_connexion == null || _connexion.State == ConnectionState.Closed)
            {
                this.GetConnection();
            }
        }

        protected void DbDeconnecter()
        {
                this._connexion.Close();
        }
        private void GetConnection()
        {
            this._connexion = new SqlConnection(this.ConnexionString);

            _connexion.Open();
        }
        //public  bool RuningTest()
        //{
        //    return AppDomain.CurrentDomain.GetAssemblies()
        //        .Any(a => a.FullName.ToLowerInvariant().Contains("nunit.framework"));
        //}
    }
}
