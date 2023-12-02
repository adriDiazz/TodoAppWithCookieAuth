using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models.Entities;

namespace WebApplication1.Data
{
    public class TodoContext : DbContext
    {

        public TodoContext() : base("DefaultConnection")
        {
        }
        public DbSet<Todo> Todos { get; set; }
        public DbSet<User> Users { get; set; }
        
    }
}