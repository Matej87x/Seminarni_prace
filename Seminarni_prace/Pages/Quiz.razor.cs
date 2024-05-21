
using Seminarni_prace.Models;
namespace Seminarni_prace.Pages
{
    public partial class Quiz
    {
        // Seznam otázek v kvízu
        private List<QuizQuestion> Questions = new List<QuizQuestion>();
        // Nová otázka, která se přidává
        private QuizQuestion NewQuestion = new QuizQuestion();
        private bool IsEditMode = false;
        // Slovník pro uchování uživatelských odpovědí na otázky
        private Dictionary<QuizQuestion, int> SelectedAnswers = new Dictionary<QuizQuestion, int>();
        // Seznam výsledků kvízu pro zobrazení
        private List<(QuizQuestion Question, bool IsCorrect)> Results = new List<(QuizQuestion Question, bool IsCorrect)>();
        // Indikátor, zda se mají zobrazit výsledky
        private bool ShowResults = false;

        // Metoda pro přidání nové otázky do seznamu otázek
        private void AddInitialQuestions()
        {
            var question1 = new QuizQuestion
            {
                Question = "Jaká je hlavní město České republiky?",
                Answers = new List<string> { "Praha", "Brno", "Ostrava", "Plzeň" },
                CorrectAnswerIndex = 0
            };

            var question2 = new QuizQuestion
            {
                Question = "Kolik je 2 + 2?",
                Answers = new List<string> { "3", "4", "5", "6" },
                CorrectAnswerIndex = 1
            };

            Questions.Add(question1);
            Questions.Add(question2);
        }

        // Metoda, která se zavolá při inicializaci komponenty
        protected override void OnInitialized()
        {
            AddInitialQuestions();
        }

        private void AddQuestion()
        {
            Questions.Add(NewQuestion);
            NewQuestion = new QuizQuestion();
        }

        // Metoda pro přepínání editačního režimu
        private void ToggleEditMode()
        {
            IsEditMode = !IsEditMode;
        }

        // Metoda pro výběr odpovědi na otázku
        private void SelectAnswer(QuizQuestion question, int answerIndex)
        {
            // Uloží vybranou odpověď pro danou otázku do slovníku
            SelectedAnswers[question] = answerIndex;
        }

        // Metoda pro vyhodnocení kvízu
        private void EvaluateQuiz()
        {
            // Vyčistí předchozí výsledky
            Results.Clear();
            foreach (var question in Questions)
            {
                // Získá vybranou odpověď pro danou otázku
                if (SelectedAnswers.TryGetValue(question, out int selectedAnswerIndex))
                {
                    // Porovná vybranou odpověď se správnou odpovědí
                    bool isCorrect = selectedAnswerIndex == question.CorrectAnswerIndex;
                    // Přidá výsledek do seznamu výsledků
                    Results.Add((question, true));
                }
                else
                {
                    // Pokud nebyla vybrána žádná odpověď, je odpověď nesprávná
                    Results.Add((question, false));
                }
            }
            // Nastaví indikátor zobrazení výsledků
            ShowResults = true;
        }
    }
}