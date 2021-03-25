using System.Collections.Generic;

namespace QuizData.Models
{
    public class Field
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Test> Tests { get; set; }
    }
}
