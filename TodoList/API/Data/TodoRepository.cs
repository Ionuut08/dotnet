using API.Entities;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class TodoRepository : ITodoRepository
    {
        private readonly DataContext _context;

        public TodoRepository(DataContext _context)
        {
            _context = context;
        }

        public void Create(TodoRepository todo)
        {
            _context.Add(todo);
            _context.SaveChanges();
        }

        public Todo GetById(id) 
        {
            return _context.Todo.Find(id);
        }

        public void Update(Todo product)
        {
            _context.Update(product);
            _context.SaveChanges();
        }

        public IEnumerable<Todo> GetAll()
        {
            return _context.Todos;
        }

        public IEnumerable<Todo> GetAllActive()
        {
            return _context.Todos;
        }

        public IEnumerable<Todo> GetAllFinished()
        {
            return _context.Todos;
        }

        public void Remove(Todo product)
        {
            _context.Remove(product);
            _context.SaveChanges();
        }
    }
}