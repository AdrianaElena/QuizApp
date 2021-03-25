using QuizData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizData
{
    public interface ITest
    {
        Test GetById(int testId);
        IEnumerable<Test> GetAll();
        IEnumerable<Question> GetQuestions(int idTest);
        IEnumerable<Answer> GetAnswerOptions(int questionId);
        public Answer GetCorrectAnswer(int questionId);
        void Add(Test newTest);

    }
}
