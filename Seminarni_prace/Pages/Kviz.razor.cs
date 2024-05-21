
//using Seminarni_prace.Models;

//namespace Seminarni_prace.Pages
//{
//    public partial class Kviz
//    {
//        private int CisloHelp3 { get; set; } = 1;

//        public string Otazka { get; set; } = "";
//        public string OdpovedR { get; set; } = "";
//        public string Odpoved1 { get; set; } = "";
//        public string Odpoved2 { get; set; } = "";
//        public string Odpoved3 { get; set; } = "";
//        private bool IsEditMode { get; set; } = false;
//        private string selectedAnswer { get; set; }
//        List<Models.Kvizik> Kviziks { get; set; } = new List<Models.Kvizik>();
//        public Kvizik Kvizos { get; set; }
//        private Dictionary<int, string> ZadaneOdpovedi = new Dictionary<int, string>();

//        private int CisloHelp { get; set; } = 0;
//        private int CisloHelp2 { get; set; } = 0;
//        private Random random = new Random();
//        private bool IsTestEvaluated { get; set; } = false;
//        private int CorrectAnswersCount { get; set; } = 0;

//        private bool isFirstQuestion => CisloHelp2 <= 0;
//        private bool isLastQuestion => CisloHelp2 >= Kviziks.Count - 1;
//        protected override void OnInitialized()
//        {
//            base.OnInitialized();
//            AddToKviziksinit();
//        }

//        private List<string> ShuffleAnswers(List<string> answers)
//        {
//            return answers.OrderBy(a => random.Next()).ToList();
//        }

    
//        public void AddToKviziks()
//        {
//            if (!string.IsNullOrWhiteSpace(OdpovedR) && !string.IsNullOrWhiteSpace(Odpoved1))
//            {
//                List<string> shuffledAnswers = ShuffleAnswers(new List<string> { Odpoved1, Odpoved2, Odpoved3, OdpovedR });
//                Kvizos = new Models.Kvizik(Otazka, shuffledAnswers[0], shuffledAnswers[1], shuffledAnswers[2], shuffledAnswers[3], CisloHelp);
//                Kviziks.Add(Kvizos);
//                CisloHelp++;

//                // Uložit zadanou odpověď pro tuto otázku
//                ZadaneOdpovedi[CisloHelp] = OdpovedR;
//            }
//        }

//        public void AddToKviziksinit()
//        {
//            {
//                List<string> shuffledAnswers = ShuffleAnswers(new List<string> { "Mounteverest", "Ježka", "Běžka", "Sněžka" });
//                Kvizos = new Models.Kvizik("Která hora je nejvyšší v ČR", shuffledAnswers[0], shuffledAnswers[1], shuffledAnswers[2], shuffledAnswers[3], CisloHelp);
//                Kvizos.ShuffleAnswers(random);
//                Kviziks.Add(Kvizos);
//                CisloHelp++;
//            }
//        }

//        private void ToggleEditMode()
//        {
//            IsEditMode = !IsEditMode;
//        }
//        private void DalsiOtazka()
//        {
//            if (!isLastQuestion)
//            {
//                CisloHelp2++;
//                CisloHelp3++;
//            }
//        }

//        private void PredchoziOtazka()
//        {
//            if (!isFirstQuestion)
//            {
//                CisloHelp2--;
//                CisloHelp3++;
//            }
//        }
//        public void VyhodnotitKviz()
//        {
//            CorrectAnswersCount = 0; // Resetovat počet správných odpovědí
//            foreach (var otazka in Kviziks)
//            {
//                // Porovnat zadanou odpověď s odpovědí označenou jako správná
//                if (ZadaneOdpovedi.ContainsKey(otazka.Cislo) && ZadaneOdpovedi[otazka.Cislo] == otazka.OdpovedSpravna)
//                {
//                    CorrectAnswersCount++; // Inkrementovat počet správných odpovědí
//                }
//            }
//            IsTestEvaluated = true; // Označit kvíz jako vyhodnocený
//        }
//    }
//    //private void VyhodnotitTest()
//    //{
//    //    {
//    //        CorrectAnswersCount = Kviziks.Count(k => k.SelectedAnswer == k.OdpovedSpravna);
//    //        IsTestEvaluated = true;
//    //    }

//    //}
//}
