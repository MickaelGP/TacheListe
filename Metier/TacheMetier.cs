using TacheConsole.Interfaces;
using TacheConsole.Models;

namespace TacheConsole.Metier
{
    public class TacheMetier : ICrud
    {
        private ITacheRepo _repo;
        public TacheMetier(ITacheRepo repo)
        {
            _repo = repo;
        }
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
            if(resultat == 0)
            {
                return 0;
            }

            return resultat;
        }

        public int UpdateTask(Taches unTache)
        {
            DateTime unDate = DateTime.Now;
            int resultat = _repo.UpdateTask(unTache);

            return resultat;
        }
    }
}
