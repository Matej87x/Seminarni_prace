namespace Seminarni_prace.Models
{
    public class Otazka
    {
        public Otazka(string text, Boolean spravna)
        {
            Text = text;
            Spravna = spravna;
        }

        public string Text { get; set; }
        public Boolean Spravna { get; set; }
    }
}