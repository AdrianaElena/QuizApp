using Microsoft.AspNetCore.Mvc;
using QuizApp.Models;
using QuizData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Controllers
{
    public class TestController : Controller
    {
        private ITest _test;

        public TestController(ITest test)
        {
            _test = test;
        }

        public IActionResult Index()
        {
            var model = _test.GetAll();
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var questions = _test.GetQuestions(id);

            var model = questions.Select(result => new TestDTO
            {
                TestId = id,
                QuestionText = result.QuestionText,
                AnswerOptions = _test.GetAnswerOptions(result.Id),
                CorrectAnswer =  _test.GetCorrectAnswer(result.Id)
            });

            return View(model);
        }
    }
}
