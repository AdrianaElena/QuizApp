using QuizData.Models;
using System.Collections.Generic;

namespace QuizData
{
    public interface IField
    {
        IEnumerable<Field> GetAll();
        Field GetById(int fieldId);
        string GetName(int fieldId);
        IEnumerable<Test> GetTests(int fieldId);
        void Add(Field newField);
    }
}
