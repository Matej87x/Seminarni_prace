using Seminarni_prace.Models;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Linq;

//AFRIKA = 1, ASIE = 0
namespace Seminarni_prace.Pages
{
    public partial class Skupiny
    {

        [Inject]
        IJSRuntime JSRuntime { get; set; }
        List<Models.Skupina> Skupinas { get; set; } = new List<Models.Skupina>();
        List<Models.Skupina> Rozdeleni { get; set; } = new List<Models.Skupina>();
        public Skupina Skup { get; set; }
        public string AddJmeno { get; set; } = "";
        public int IDskup { get; set; } = 6;
        public int IDHelp { get; set; } = 0;
        private bool IsEditMode { get; set; } = false;

        public string AddJmeno1 { get; set; } = "";
        public int IDskup1 { get; set; }

        protected override void OnInitialized() //onload funkce při načtení se mi to uděla prostě
        {
            base.OnInitialized();
            PridejStat();
            PridejRozdeleni();
        }
        public void AddToSkupinas()
        {
            Skup = new Models.Skupina(AddJmeno, IDskup, IDHelp);
            Skupinas.Add(Skup);
           
        }
        public void AddToRozdeleni()
        {
            Skup = new Models.Skupina(AddJmeno1, IDskup1, IDskup);
            Rozdeleni.Add(Skup);
            IDskup++;
        }
        public void PridejStat()
        {
            Skupinas.Add(new Models.Skupina("Nigerie", 1, 0));
            Skupinas.Add(new Models.Skupina("Francie", 2, 8));
            Skupinas.Add(new Models.Skupina("Vietnam", 0, 5));
            Skupinas.Add(new Models.Skupina("Egypt", 1, 1));
            Skupinas.Add(new Models.Skupina("Korea", 0, 3));
            Skupinas.Add(new Models.Skupina("Slovensko", 2, 7));
            Skupinas.Add(new Models.Skupina("Čína", 0, 4));
            Skupinas.Add(new Models.Skupina("JAR", 1, 2));
            Skupinas.Add(new Models.Skupina("Česká Republika", 2, 6));
          
          

        }
        public void PridejRozdeleni()
        {
            Rozdeleni.Add(new Models.Skupina("Afrika", 1, 1));
            Rozdeleni.Add(new Models.Skupina("Asie", 0, 0));
            Rozdeleni.Add(new Models.Skupina("Evropa", 2, 2));

        }
        private void ToggleEditMode()
        {
            IsEditMode = !IsEditMode;
        }
        private async Task Vyhodnotit()
        {
            foreach (var item in Skupinas)
            {
                var elementId = $"item-{item.IDS}";
                var parent = Rozdeleni.FirstOrDefault(r => r.IDS == item.IDS);
                bool isCorrect = parent != null && item.IDS == parent.IDS;

                var evalResult = isCorrect ? "correct" : "incorrect";
                await JSRuntime.InvokeVoidAsync("updateElementStyle", elementId, evalResult);
            }
        }


    }
}
