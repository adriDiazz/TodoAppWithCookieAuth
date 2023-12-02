using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models.Entities;

namespace WebApplication1.Repositories
{
    internal interface ITodoRepository : IDisposable
    {
        IEnumerable<Todo> GetTodos();
        Todo GetTodoById(int todoId);
        void InsertTodo (Todo todo);
        void DeleteTodo (int todoId);
        void UpdateTodo (Todo todo);
        void Save();
    }
}
