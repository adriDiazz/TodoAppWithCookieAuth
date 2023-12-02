using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models.DTOs;
using WebApplication1.Models.Entities;

namespace WebApplication1.Services
{
    internal interface ITodosService : IDisposable
    {
        IEnumerable<Todo> GetTodos();
        Todo GetTodoById(int todoId);
        void CreateTodo(CreateTodoDto todo);
        void UpdateTodo(UpdateTodoDto todo);
        void DeleteTodo(int todoId);
    }
}
