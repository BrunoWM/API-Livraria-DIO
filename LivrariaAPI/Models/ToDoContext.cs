using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LivrariaAPI.Models;

namespace LivrariaAPI.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> option) : base(option)
        {

        }

        public DbSet<Livro> TodoLivros { get; set; }
    }
}
