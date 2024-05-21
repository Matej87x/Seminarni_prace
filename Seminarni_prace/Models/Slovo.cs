namespace Seminarni_prace.Models
{
    public abstract class Slovo

    {
        public Slovo(String urciteSlovo) { 
        UrciteSlovo = urciteSlovo;
        }
        public String UrciteSlovo { get; set; } = "";
    }
}
