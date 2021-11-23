using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio1PreAccAlkemy
{
    class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public Usuario Usuario { get; set; }
    }
}
