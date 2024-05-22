
using Seminarni_prace.Models;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace Seminarni_prace.Pages
{

    public partial class Prirazovacka
    {

        public int Help { get; set; } = 3;
        //public int StaticHelp { get; set; } = 3;
        //public int ActiveHelp { get; set; } = 3;
        List<Models.Cas> Static { get; set; } = new List<Models.Cas>();
        List<Models.Cas> Active { get; set; } = new List<Models.Cas>();
        public Cas cas { get; set; }
        public Cas cas1 { get; set; }
        private bool IsEditMode { get; set; } = false;
        public string Obrazek { get; set; }
        public string SlovoObrazek { get; set; }




        protected override void OnInitialized()
        {
            base.OnInitialized();
            AddToStaticIni();
            AddToActiveIni();
        }
        //Přidání obrázků a názvů po načtení stránky
        public void AddToStaticIni()
        {
            Static.Add(new Models.Cas(1, "../img/Kun.jpg"));
            Static.Add(new Models.Cas(0, "../img/Kocka.jpeg"));
            Static.Add(new Models.Cas(2, "../img/Pes.jpeg"));
      
      
        }
        //Přidání obrázků a názvů po načtení stránky

        public void AddToActiveIni()
        {
            Active.Add(new Models.Cas(0, "Kočka"));
            Active.Add(new Models.Cas(1, "Kun"));
            Active.Add(new Models.Cas(2, "Pes"));
        }
        //Přidání Obrázků a názvů, které chce člověk, který je na stránce
        public void AddToActive()
        {
            if (!string.IsNullOrWhiteSpace(Obrazek) && !string.IsNullOrWhiteSpace(SlovoObrazek))
            {
                cas = new Models.Cas(Help,SlovoObrazek);
                Active.Add(cas);
            }
        }
        //Přidání Obrázků a názvů, které chce člověk, který je na stránce

        public void AddToStatic()
        {
            if (!string.IsNullOrWhiteSpace(Obrazek) && !string.IsNullOrWhiteSpace(SlovoObrazek))
            {
                cas1 = new Models.Cas(Help, Obrazek);
                Static.Add(cas1);
            }
        }

        public void Pridej()
        {
            AddToActive();
            AddToStatic();
            Help++;
        }
        private void ToggleEditMode()
        {
            IsEditMode = !IsEditMode;
        }
        private void Smazat(Cas pol)
        {
            Static.Remove(pol);
            Active.Remove(pol);
        }
        
    }
}   