using Microsoft.AspNetCore.Mvc;
using QuizData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Controllers
{
    public class FieldController : Controller
    {
        private IField _field;

        public FieldController(IField field)
        {
            _field = field;
        }

        public IActionResult Index()
        {
            var model = _field.GetAll();
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var model = _field.GetTests(id);

            return View(model);
        }
    }
}
