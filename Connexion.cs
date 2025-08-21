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

        public Connexion()
        {
            ConnexionString = "azert";
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
    }
}
