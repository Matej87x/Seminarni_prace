namespace Seminarni_prace.Models
{
    public class Odpoved
    {
        public Odpoved(Boolean spravne, string text) { 
        Spravne = spravne;
            Text = text;
        }

        public Boolean Spravne { get; set; } = false;
        public string Text { get; set; } = "";
    }
}
