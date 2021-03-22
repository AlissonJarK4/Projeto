using System.Collections.Generic;

namespace Projeto.Models
{
    public class Quiz
    {
        public string Id { get; set; }
        public string Question { get; set; }

        public List<Answer> Answers { get; set; }

        public long CorrectAnswerId { get; set; }
    }
}