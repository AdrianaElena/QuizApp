using System.Collections.Generic;

namespace QuizData.Models
{
    public class Test
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public string Description { get; set; }
        public IEnumerable<Question> Questions { get; set; }
    }
}
