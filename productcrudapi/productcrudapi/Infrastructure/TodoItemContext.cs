using Microsoft.EntityFrameworkCore;
using productcrudapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productcrudapi.Infrastructure
{
    public class TodoItemContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }

        public TodoItemContext(DbContextOptions<TodoItemContext> options) : base(options)
        {

        }
    }
}
