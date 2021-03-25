using Microsoft.EntityFrameworkCore;
using QuizData;
using QuizData.Models;
using System.Collections.Generic;
using System.Linq;

namespace QuizServices
{
    public class TestService : ITest
    {
        private QuizContext _context;

        public TestService(QuizContext context)
        {
            _context = context;
        }
        
        public void Add(Test newTest)
        {
            _context.Add(newTest);
            _context.SaveChanges();
        }

        public IEnumerable<Test> GetAll()
        {
            return _context.Tests;
        }

        public Test GetById(int testId)
        {
            return _context.Tests.FirstOrDefault(t => t.Id == testId);
        }

        public IEnumerable<Question> GetQuestions(int testId)
        {
            var model =  _context.Tests
                .Include(t => t.Questions)
                .FirstOrDefault(t => t.Id == testId)
                .Questions;
            return model;
        }

        public IEnumerable<Answer> GetAnswerOptions(int questionId)
        {
            return _context.Questions.Include(q => q.AnswerOptions).FirstOrDefault(q => q.Id == questionId).AnswerOptions;
        }

        public Answer GetCorrectAnswer(int questionId)
        {
            return _context.Questions
                .Include(q => q.AnswerOptions)
                .FirstOrDefault(q => q.Id == questionId)
                .AnswerOptions.FirstOrDefault(a => a.CorrectAnswer == true);
        }
    }
}
