namespace Seminarni_prace.Models
{
    public class Cas : Slovo
    {
        public Cas(int rok, string urciteSlovo) : base(urciteSlovo)
        {
                  

        Rok = rok;
            UrciteSlovo = urciteSlovo;

        }

        public int Rok {  get; set; }
        public bool IsCorrect { get; set; } = false; // Nová vlastnost
    }
}
