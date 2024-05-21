using Seminarni_prace.Models;
namespace Seminarni_prace.Pages
   

{
    public partial class Serazovacka
    {
        List<Cas> Serad {  get; set; } = new List<Cas>();
        protected override void OnInitialized()
        {
            base.OnInitialized();
            AddToSeradINI();
        }
        public void AddToSeradINI()
        {
            Serad.Add(new Models.Cas(1, "1"));
            Serad.Add(new Models.Cas(2, "2"));
            Serad.Add(new Models.Cas(3, "3"));
            Serad.Add(new Models.Cas(4, "4"));
            Serad.Add(new Models.Cas(5, "5"));
            Serad.Add(new Models.Cas(6, "6"));
            Serad.Add(new Models.Cas(7, "7"));
        }
    }
}
