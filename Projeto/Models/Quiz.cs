using System.Collections.Generic;

namespace Projeto.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Question { get; set; }

        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }

        public int CorrectAnswer { get; set; }
    }
}