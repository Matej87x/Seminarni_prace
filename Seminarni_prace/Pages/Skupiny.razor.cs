using Seminarni_prace.Models;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Linq;

//AFRIKA = 1, ASIE = 0
namespace Seminarni_prace.Pages
{
    public partial class Skupiny
    {

       
        List<Models.Skupina> Skupinas { get; set; } = new List<Models.Skupina>();
        List<Models.Skupina> Rozdeleni { get; set; } = new List<Models.Skupina>();
       

        protected override void OnInitialized() //onload funkce při načtení se mi to uděla prostě
        {
            base.OnInitialized();
            PridejStat();
            PridejRozdeleni();
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
        
        


    }
}
