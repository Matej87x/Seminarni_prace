using Microsoft.AspNetCore.Components;
using Seminarni_prace.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace Seminarni_prace.Pages
{
    public partial class Quiz
    {
        private List<QuizQuestion> Questions = new List<QuizQuestion>();
        private QuizQuestion NewQuestion = new QuizQuestion();
        private bool IsEditMode = false;
        private Dictionary<QuizQuestion, int> SelectedAnswers = new Dictionary<QuizQuestion, int>();
     
        private List<(QuizQuestion Question, bool IsCorrect)> Results = new List<(QuizQuestion Question, bool IsCorrect)>();
      
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
            if (!string.IsNullOrEmpty(NewQuestion.Question) && NewQuestion.Answers.Count > 0)
            {
                Questions.Add(NewQuestion);
                NewQuestion = new QuizQuestion();
            }
        }

        private void Smazat(QuizQuestion question)
        {
            Questions.Remove(question);
        }

        private void RemoveAnswer(int index)
        {
            if (index >= 0 && index < NewQuestion.Answers.Count)
            {
                NewQuestion.Answers.RemoveAt(index);
            }
        }

        private void AddAnswer()
        {
            NewQuestion.Answers.Add(string.Empty);
        }

        private void UpdateAnswer(ChangeEventArgs e, int index)
        {
            Debug.WriteLine($"Updated answer at index: {index}, New value:{e.Value}");
            if (index >= 0 && index < NewQuestion.Answers.Count)
            {
                NewQuestion.Answers[index] = e.Value?.ToString() ?? string.Empty;
            }
        }

        // Metoda pro přepínání editačního režimu
        private void ToggleEditMode()
        {
            IsEditMode = !IsEditMode;
        }

        // Metoda pro výběr odpovědi na otázku
        private void SelectAnswer(QuizQuestion question, ChangeEventArgs e)
        {
            // Uloží vybranou odpověď pro danou otázku do slovníku
            SelectedAnswers[question] = Int32.Parse(e.Value.ToString());
        }

        // Metoda pro vyhodnocení kvízu
         private void EvaluateQuiz()
        {
            if (!ShowResults)
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
                        Results.Add((question, isCorrect));
                    }
                    else
                    {
                        // Pokud nebyla vybrána žádná odpověď, je odpověď nesprávná
                        Results.Add((question, false));
                    }
                }
                ShowResults = true;
            }
            
            
        }
    }
}