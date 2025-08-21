using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TacheConsole.Interfaces;
using TacheConsole.Models;
using TacheConsole.Repository;

namespace TacheConsole.Metier
{
    public class TacheMetier : ICrud
    {
        private TacheRepo _repo = new TacheRepo();

        public int DeleteTask(int unId)
        {
            int resultat = _repo.DeleteTask(unId);

            return resultat;
        }

        public List<Taches> GetAllTacheForDelete()
        {
            List<Taches> listeTaches = _repo.GetAllTacheForDelete();

            return listeTaches;
        }

        public List<Taches> GetAllTask()
        {
            List<Taches> listeTaches = _repo.GetAllTask();

            return listeTaches;
        }

        public Taches GetTaskById(int unId)
        {
            Taches uneTache = _repo.GetTaskById(unId);

            return uneTache;
        }

        public int InsertTask(Taches uneTache)
        {
            uneTache.tacheCreation = DateTime.Now;

            int resultat = _repo.InsertTask(uneTache);

            return resultat;
        }

        public int UpdateTask(int unId)
        {
            DateTime unDate = DateTime.Now;
            int resultat = _repo.UpdateTask(unId, unDate);

            return resultat;
        }
    }
}
