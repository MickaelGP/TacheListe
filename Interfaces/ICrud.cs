using TacheConsole.Models;

namespace TacheConsole.Interfaces
{
    public interface ICrud
    {
        public List<Taches> GetAllTask();

        public Taches GetTaskById(int unId);

        public int UpdateTask(Taches unTache);

        public int DeleteTask(int unId);

        public int InsertTask(Taches uneTache);

        public List<Taches> GetAllTacheForDelete();
    }
}
