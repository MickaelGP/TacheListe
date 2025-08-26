namespace TacheConsole.Models
{
    public class Taches
    {
        public int tacheId { get; set; }

        public string tacheNom { get; set; }

        public string tacheDescription { get; set; }

        public DateTime tacheCreation { get; set; }

        public DateTime tacheTerminer { get; set; }

        public Taches() { }

        public Taches(string unNom, string unDescription)
        {
            this.tacheNom = unNom;
            this.tacheDescription = unDescription;
        }
    }
}
