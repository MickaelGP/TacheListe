using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TacheConsole.Models;

namespace TacheConsole.Interfaces
{
    public interface ICrud
    {
        public List<Taches> GetAllTask();

        public Taches GetTaskById(int unId);

        public int UpdateTask(int unId);

        public int DeleteTask(int unId);

        public int InsertTask(Taches uneTache);
    }
}
