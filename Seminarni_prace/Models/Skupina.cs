namespace Seminarni_prace.Models

{
    public class Skupina : Slovo
    {
        public Skupina(string urciteSlovo, int skupinka, int iDS) : base(urciteSlovo)
        {
            Skupinka = skupinka;
            IsCorrectlyGrouped = null;
            IDS = iDS;
        }
        public int Skupinka { get; set; }
        public int IDS { get; set; }
        public bool? IsCorrectlyGrouped { get; set; }

    }


}
