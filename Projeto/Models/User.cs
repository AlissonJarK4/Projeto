using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public List<Quiz> Favorites { get; set; }
    }
}
