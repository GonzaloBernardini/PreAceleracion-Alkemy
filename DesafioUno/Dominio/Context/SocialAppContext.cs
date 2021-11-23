using Desafio1PreAccAlkemy;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Context
{
    class SocialAppContext : DbContext
    {
        //Constructor
        public SocialAppContext()
        {

        }
        //Clases a mapearse como tablas en Base De Datos
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Post> Posts { get; set; }

    }
}
