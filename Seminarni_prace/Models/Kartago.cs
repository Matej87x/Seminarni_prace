namespace Seminarni_prace.Models
{
    public class Kartago : Slovo
    {
        public Kartago(string urciteSlovo, string otazka) : base(urciteSlovo) {
        Otazka = otazka; 
        UrciteSlovo = urciteSlovo;
        }

        public string Otazka { get; set; } = "";   
    }
}
