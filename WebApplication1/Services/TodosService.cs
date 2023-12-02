using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models.DTOs;
using WebApplication1.Models.Entities;
using WebApplication1.Repositories;

namespace WebApplication1.Services
{
    public class TodosService: ITodosService, IDisposable
    {
        
        ITodoRepository todoRepository;

        public TodosService()
        {
            todoRepository = new TodoRepository();
        }

        public IEnumerable<Todo> GetTodos()
        {
            return todoRepository.GetTodos();
        }

        public Todo GetTodoById(int todoId)
        {
            return todoRepository.GetTodoById(todoId);
        }

        public void CreateTodo(CreateTodoDto todo)
        {
            Todo newTodo = new Todo
            {
                Name = todo.Name,
                Description = todo.Description,
                IsComplete = false
            };
            todoRepository.InsertTodo(newTodo);
            todoRepository.Save();
        }

        public void UpdateTodo(UpdateTodoDto todo)
        {
            Todo updatedTodo = new Todo
            {
                Id = todo.Id,
                Name = todo.Name,
                Description = todo.Description,
                IsComplete = todo.IsComplete
            };
            todoRepository.UpdateTodo(updatedTodo);
            todoRepository.Save();
        }

        public void DeleteTodo (int todoId)
        {
            todoRepository.DeleteTodo(todoId);
            todoRepository.Save();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose (bool disposing)
        {
            if (disposing)
            {
                if (todoRepository != null)
                {
                    todoRepository.Dispose();
                    todoRepository = null;
                }
            }
        } 
    }
}