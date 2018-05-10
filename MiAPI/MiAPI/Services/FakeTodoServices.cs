using MiAPI.Models;
using MiAPI.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiAPI.Services
{
    public interface ITodoService
    {
        IList<TodoList> GetTodoLists();
    }

    public class TodoService : ITodoService
    {
        private readonly ApplicationContext _context;

        public TodoService(ApplicationContext context)
        {
            _context = context;
        }

        public IList<TodoList> GetTodoLists()
        {
            return _context.TodoLists.Include(t => t.Items).ToList();
        }
    }

    public class FakeTodoServices : ITodoService
    {
        public FakeTodoServices()
        {

        }

        public IList<TodoList> GetTodoLists()
        {
            var list1 = new TodoList()
            {
                Id = 1,
                Name = "Lista de la compra",
                Owner = "Beatriz",
                Items = new List<TodoItem>()
                {
                   new TodoItem() {TodoListId = 1, Description = "Huevos" },
                   new TodoItem() {TodoListId = 2, Description = "Espinacas" },
                   new TodoItem() {TodoListId = 3, Description = "Leche" },
                   new TodoItem() {TodoListId = 4, Description = "Yogures" },
                }
            };

            var listCollection = new List<TodoList>
            {
                list1
            };
            return listCollection;
        }
    }
}
