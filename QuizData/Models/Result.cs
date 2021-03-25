using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizData.Models
{
    public class Result
    {
        public int Id { get; set; }

        [Range(0, 100)]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal TestScore { get; set; }
        public User User { get; set; }
        public Test Test { get; set; }
    }
}
