using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizData.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }

        [Range(1, 100)]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Score { get; set; }
        public IEnumerable<Answer> AnswerOptions { get; set; }
    }
}
