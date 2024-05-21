namespace Seminarni_prace.Models
{
    public class Kvizik : Slovo
    {        

        public Kvizik(string urciteSlovo,string odpovedSpatna1, string odpovedSpatna2, string odpovedSpatna3, string odpovedSpravna,int cislo) : base(urciteSlovo)
        {
            OdpovedSpatna1 = odpovedSpatna1;
            OdpovedSpatna2 = odpovedSpatna2;
            OdpovedSpravna = odpovedSpravna;
            OdpovedSpatna3 = odpovedSpatna3;
            UrciteSlovo = urciteSlovo;
            Cislo = cislo;
          

            ShuffledAnswers = new List<string> { odpovedSpatna1, odpovedSpatna2, odpovedSpatna3, odpovedSpravna };



        }
        public void ShuffleAnswers(Random random)
        {
            ShuffledAnswers = ShuffledAnswers.OrderBy(a => random.Next()).ToList();
        }
        public string OdpovedSpravna {  get; set; }
        public string OdpovedSpatna1 { get; set; }
        public string OdpovedSpatna2 { get; set; }
        public string OdpovedSpatna3 { get; set; }
        public int Cislo { get; set; } = 0;

        public string SelectedAnswer { get; set; }
        public List<string> ShuffledAnswers { get; set; }

    }
}
