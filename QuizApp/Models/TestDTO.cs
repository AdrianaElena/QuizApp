using QuizData.Models;
using System.Collections.Generic;

namespace QuizApp.Models
{
    public class TestDTO
    {
        public int TestId { get; set; }
        public string QuestionText { get; set; }
        public IEnumerable<Answer> AnswerOptions { get; set; }
        public Answer CorrectAnswer { get; set; }

    }
}
