namespace Seminarni_prace.Models
{
    public class QuizQuestion
    {
        public string Question { get; set; }
        public List<string> Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }

        public QuizQuestion()
        {
            Answers = new List<string>(new string[2]);
        }
    }
}