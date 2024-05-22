using Seminarni_prace.Models;
using System;

namespace Seminarni_prace.Pages
{
    public partial class Karty
    {

        public List<Models.Kartago> Kartys { get; set; } = new List<Models.Kartago>();
        public Kartago Kart { get; set; }

        public string Question { get; set; } = "";

        public string Answer { get; set; } = "";
        private bool IsEditMode { get; set; } = false;
      


        protected override void OnInitialized() //onload funkce při načtení se mi to uděla prostě
        {
            base.OnInitialized();
            AddToKartysinit();
            
        }
        //Přidání karet po načtení stránky
        public void AddToKartysinit()
        {
            Kart = new Models.Kartago("Sněžka", "Která hora je nejvyšší v ČŘ");
            Kartys.Add(Kart);
        }
       //Přidání karet uživateelm
       public void AddToKartys(){
            if (!string.IsNullOrWhiteSpace(Question) && !string.IsNullOrWhiteSpace(Answer))
            {
                Kart = new Models.Kartago(Answer, Question);
                Kartys.Add(Kart);
            }
        }
        private void ToggleEditMode()
        {
            IsEditMode = !IsEditMode;
        }
        private void Smazat(Kartago pol)
        {
            Kartys.Remove(pol);
            
        }


    }
}
