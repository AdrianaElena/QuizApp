using Microsoft.EntityFrameworkCore;
using QuizData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizData
{
    public class QuizContext: DbContext
    {
        public QuizContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Result> Results { get; set; }
    }
}
