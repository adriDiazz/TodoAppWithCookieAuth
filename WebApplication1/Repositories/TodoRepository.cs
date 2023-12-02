using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Data;
using WebApplication1.Models.Entities;

namespace WebApplication1.Repositories
{
    public class TodoRepository : ITodoRepository, IDisposable
    { 
        private TodoContext context = new TodoContext();

        public IEnumerable<Todo> GetTodos()
        { 
            return context.Todos.ToList();
        }
        public Todo GetTodoById(int todoId) 
        {
            return context.Todos.Find(todoId);
        }
        public void InsertTodo (Todo todo)
        {
            context.Todos.Add(todo);
        }
        public void DeleteTodo (int todoId)
        {
            Todo todo = context.Todos.Find(todoId);
            if (todo != null)
                context.Todos.Remove(todo);
        }
        public void UpdateTodo (Todo todo)
        {
            context.Entry(todo).State = System.Data.Entity.EntityState.Modified;
        }
        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (context != null)
                {
                    context.Dispose();
                    context = null;
                }
            }
        }
    }
}