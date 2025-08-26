using TacheConsole.Models;

namespace TacheConsole.Interfaces
{
    public interface ITacheRepo
    {
        public int DeleteTask(int unId);

        public List<Taches> GetAllTacheForDelete();

        public List<Taches> GetAllTask();

        public Taches GetTaskById(int unId);

        public int InsertTask(Taches uneTache);

        public int UpdateTask(Taches unTache);
    }
}
