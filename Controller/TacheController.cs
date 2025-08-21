using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TacheConsole.Metier;
using TacheConsole.Models;

namespace TacheConsole.Controller
{
    public class TacheController
    {
        private TacheMetier _metier = new TacheMetier();

        public void CreateTache()
        {
            Console.WriteLine("Ajouter un nom de tache :");
            string nom = Console.ReadLine();

            Console.WriteLine("Ajouter une description :");
            string description = Console.ReadLine();

            Taches unTache = new Taches(nom, description);

            int result = _metier.InsertTask(unTache);

            if (result == 0)
            {
                Console.WriteLine("Une erreur est survenue");
            }
            else
            {
                Console.WriteLine("Tache ajoutée");
            }
        }
        public void ShowAllTask()
        {
            List<Taches> taches = _metier.GetAllTask();
            foreach (var tache in taches)
            {
                Console.WriteLine($"Id : {tache.tacheId} / Nom : {tache.tacheNom}");
            }
        }
        public List<Taches> GetAllTask()
        {
            List<Taches> taches = _metier.GetAllTask();
            return taches;
        }

        public void DeleteTache()
        {
            List < Taches > taches = _metier.GetAllTacheForDelete();
            Console.WriteLine("Liste des tâches en cours");
            foreach (var tache in taches) {
                Console.WriteLine($"Id : {tache.tacheId} / Nom : {tache.tacheNom}");
            }
            Console.WriteLine("Inscrivez l'id de la tâche à supprimer :");

            int idTache = Convert.ToInt32(Console.ReadLine());

            int resultat = _metier.DeleteTask(idTache);

            if(resultat == 0)
            {
                Console.WriteLine("Une erreur est survenue !");
            }
            else
            {
                Console.WriteLine("Tâche supprimée");
            }
        }

        public void UpdateTache()
        {
            List<Taches> taches = GetAllTask();
            Console.WriteLine("Liste des tâches en cours");
            foreach (var tache in taches)
            {
                Console.WriteLine($"Id : {tache.tacheId} / Nom : {tache.tacheNom}");
            }
            Console.WriteLine("Inscrivez l'id de la tâche à marquer comme terminer :");
            int idTache = Convert.ToInt32(Console.ReadLine());
            int resultat = _metier.UpdateTask(idTache);
            if (resultat == 0)
            {
                Console.WriteLine("Une erreur est survenue !");
            }
            else
            {
                Console.WriteLine("Tâche mise à jour !");
            }
        }
    }
}
