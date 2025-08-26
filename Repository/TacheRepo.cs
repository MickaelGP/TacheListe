using Microsoft.Data.SqlClient;
using System.Data;
using TacheConsole.Interfaces;
using TacheConsole.Models;

namespace TacheConsole.Repository
{
    public class TacheRepo : Connexion, ITacheRepo
    {
        public int DeleteTask(int unId)
        {
            DbConnecter();

            SqlCommand cmd = _connexion.CreateCommand();

            cmd.CommandText = "DELETE FROM taches WHERE tacheId = @tacheId";

            SqlParameter tacheId = cmd.Parameters.Add("@tacheId", SqlDbType.Int);

            tacheId.Value = unId;

            int resultat = cmd.ExecuteNonQuery();

            DbConnecter();

            return resultat;
        }

        public List<Taches> GetAllTacheForDelete()
        {
            DbConnecter();

            List<Taches> listeTaches = new List<Taches>();

            SqlCommand cmd = _connexion.CreateCommand();

            cmd.CommandText = "SELECT * FROM taches";

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Taches taches = new Taches
                {
                    tacheId = (int)reader["tacheId"],
                    tacheNom = reader["tacheNom"].ToString(),
                    tacheDescription = reader["tacheDescription"].ToString()
                };
                listeTaches.Add(taches);
            }

            DbDeconnecter();

            return listeTaches;
        }

        public List<Taches> GetAllTask()
        {
            DbConnecter();

            List<Taches> listeTaches = new List<Taches>();

            SqlCommand cmd = _connexion.CreateCommand();

            cmd.CommandText = "SELECT * FROM taches WHERE tacheTerminer IS NULL";

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Taches taches = new Taches
                {
                    tacheId = (int)reader["tacheId"],
                    tacheNom = reader["tacheNom"].ToString(),
                    tacheDescription = reader["tacheDescription"].ToString()
                };
                listeTaches.Add(taches);
            }

            DbDeconnecter();

            return listeTaches;
        }

        public Taches GetTaskById(int unId)
        {
            DbConnecter();

            Taches unTodo = null;

            SqlCommand cmd = _connexion.CreateCommand();

            cmd.CommandText = "SELECT * FROM taches WHERE tacheId = @tacheId";

            SqlParameter tacheId = cmd.Parameters.Add("@tacheId", SqlDbType.Int);

            tacheId.Value = unId;

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                unTodo = new Taches
                {
                    tacheId = (int)reader["tacheId"],
                    tacheNom = reader["tacheNom"].ToString(),
                    tacheDescription = reader["tacheDescription"].ToString()
                };
            }

            DbDeconnecter();

            return unTodo;
        }

        public int InsertTask(Taches uneTache)
        {
            DbConnecter();

            SqlCommand cmd = _connexion.CreateCommand();

            cmd.CommandText = "INSERT INTO taches (tacheNom, tacheDescription, tacheCreation ) VALUES (@tacheNom, @tacheDescription, @tacheCreation )";

            SqlParameter tacheNom = cmd.Parameters.Add("@tacheNom", SqlDbType.VarChar);
            SqlParameter tacheDescription = cmd.Parameters.Add("@tacheDescription", SqlDbType.VarChar);
            SqlParameter tacheCreation = cmd.Parameters.Add("@tacheCreation", SqlDbType.DateTime);

            tacheNom.Value = uneTache.tacheNom;
            tacheDescription.Value = uneTache.tacheDescription;
            tacheCreation.Value = uneTache.tacheCreation;

            int resultat = cmd.ExecuteNonQuery();

            DbDeconnecter();

            return resultat;
        }

        public int UpdateTask(Taches unTache)
        {
            DbConnecter();

            SqlCommand cmd = _connexion.CreateCommand();

            cmd.CommandText = "UPDATE taches SET  tacheTerminer = @tacheTerminer WHERE tacheId = @tacheId";

            SqlParameter tacheTerminer = cmd.Parameters.Add("@tacheTerminer", SqlDbType.DateTime);
            SqlParameter tacheId = cmd.Parameters.Add("@tacheId", SqlDbType.Int);

            tacheTerminer.Value = unTache.tacheTerminer;
            tacheId.Value = unTache.tacheId;

            int resultat = cmd.ExecuteNonQuery();

            DbDeconnecter();

            return resultat;
        }
    }
}
