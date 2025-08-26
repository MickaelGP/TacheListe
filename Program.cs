using TacheConsole.Controller;
using TacheConsole.Interfaces;
using TacheConsole.Metier;
using TacheConsole.Models;
using TacheConsole.Repository;
namespace TacheConsole
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Environment.SetEnvironmentVariable("app", "console");
            Console.WriteLine(Environment.GetEnvironmentVariable("app"));
            ITacheRepo repo = new TacheRepo(); // nécessite une connexion valide
            ICrud metier = new TacheMetier(repo);
            TacheController _controller = new TacheController(metier);
            int choix = 1;
            Intro();
            do
            {
                
                Console.WriteLine("===========Votre choix :===========");
                choix = Convert.ToInt32(Console.ReadLine());
                switch (choix)
                {
                    case 0:
                        Console.WriteLine("Au revoir !");
                        break;
                    case 1:
                        _controller.CreateTache();
                        Intro();
                        break;
                    case 2:
                        _controller.ShowAllTask();
                        Intro();
                        break;
                    case 3:
                        _controller.UpdateTache();
                        Intro();
                        break;
                    case 4:
                        _controller.DeleteTache();
                        Intro();
                        break;
                    default:
                        Console.WriteLine("Commande non reconnue");
                        break;
                }
            } while (choix != 0);
        }
        public static void Intro()
        {
            Console.WriteLine("===========Les choix possible :===========");
            Console.WriteLine("0 pour quitter");
            Console.WriteLine("1 pour ajouter une tâche");
            Console.WriteLine("2 pour consulter les tâches");
            Console.WriteLine("3 pour terminer une tâche");
            Console.WriteLine("4 pour supprimer une tâche");
        }
    }
}

