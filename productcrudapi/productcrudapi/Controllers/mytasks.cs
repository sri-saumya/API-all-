using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using productcrudapi.Infrastructure;
using productcrudapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productcrudapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class mytasks : ControllerBase
    {

        private readonly TodoItemContext _context;

        public mytasks(TodoItemContext context)
        {
            _context = context;
        }

        [HttpGet("items")]
        public List<TodoItem> getItems()
        {
            var result = from r in _context.TodoItems select r;
            return result.ToList();
        }

        [HttpPost("items")]
        public TodoItem createItem(TodoItem item)
        {
            _context.TodoItems.Add(item);
            _context.SaveChanges();
            return item;
        }

        [HttpPut("items/{id}")]
        public TodoItem updateItem(TodoItem item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
            return item;
        }
    }
}
