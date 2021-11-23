using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio1PreAccAlkemy
{
    class Comment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Comments { get; set; }
        public Usuario Usuario { get; set; }

    }
}
