using Seminarni_prace.Models;
namespace Seminarni_prace.Pages
{
    public partial class TimeLine
    {
        public int Rok { get; set; }
        public string Popis { get; set; } = "";
        List<Models.Cas> Casek { get; set; } = new List<Models.Cas>();

        public Cas Casovac { get; set; }


        protected override void OnInitialized() //onload funkce při načtení se mi to uděla prostě
        {
            base.OnInitialized();
            AddToCasovacIni();

        }
        public void AddToCasovac()
        {
            Casovac = new Models.Cas(Rok, Popis);
            Casek.Add(Casovac);
        }
        public void AddToCasovacIni()
        {
            Casek.Add(new Models.Cas(1212, "Zlatá bula sicilská"));
            Casek.Add(new Models.Cas(1300, "Bitva"));
            Casek.Add(new Models.Cas(1420, "Bitva u Lipan"));
            Casek.Add(new Models.Cas(1600, "Ossos"));

        }


    }
}




 