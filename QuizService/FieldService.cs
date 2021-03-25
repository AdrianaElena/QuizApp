using Microsoft.EntityFrameworkCore;
using QuizData;
using QuizData.Models;
using System.Collections.Generic;
using System.Linq;

namespace QuizServices
{
    public class FieldService : IField
    {
        private QuizContext _context;

        public FieldService(QuizContext context)
        {
            _context = context;
        }

        public void Add(Field newField)
        {
            _context.Add(newField);
            _context.SaveChanges();
        }

        public IEnumerable<Field> GetAll()
        {
            return _context.Fields.Include(f => f.Tests);
        }

        public Field GetById(int fieldId)
        {
            return GetAll().FirstOrDefault(f => f.Id == fieldId);
        }

        public string GetName(int fieldId)
        {
            return _context.Fields.FirstOrDefault(f => f.Id == fieldId).Name;
        }

        public IEnumerable<Test> GetTests(int fieldId)
        {
            var testList = _context.Fields.Include(f=>f.Tests).FirstOrDefault(f => f.Id == fieldId);
            return testList.Tests;
        }
    }
}
