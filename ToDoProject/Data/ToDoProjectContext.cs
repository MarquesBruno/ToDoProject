using Microsoft.EntityFrameworkCore;
using ProjetoTest.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoProject.Data
{
    public class ToDoProjectContext : DbContext
    {
        public ToDoProjectContext(DbContextOptions<ToDoProjectContext> options) : base(options)
        {
        }        

        public DbSet<User> Users { get; set; }
        public DbSet<ToDo> ToDoes { get; set; }
    }
    
}
