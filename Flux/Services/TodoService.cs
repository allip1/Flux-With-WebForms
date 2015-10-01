using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FormsFluxProto.Models;

namespace FormsFluxProto.Flux.Services
{
    /// <summary>
    /// Plays dbs role here
    /// </summary>
    public static class TodoDataStorage
    {
        //todo table
        public static Dictionary<Guid, TodoModel> _todos = init().ToDictionary(x=> x.Id);

        private static List<TodoModel> init()
        {
            List<TodoModel> todos = new List<TodoModel>();

            for(int i = 0; i < 1000; i++)
            {
                todos.Add(new TodoModel("testi" + i));
            }

            return todos;
        }
    }

    public class TodoService
    {
        public void AddTodo(TodoModel todo)
        {
            TodoDataStorage._todos.Add(todo.Id, todo);
        }
        
        public void UpdateTodo(TodoModel todo)
        {
            TodoDataStorage._todos[todo.Id] = todo;
        }

        public void DeleteTodo(TodoModel todo)
        {
            TodoDataStorage._todos.Remove(todo.Id);
        }

        public List<TodoModel> GetAll()
        {
            return TodoDataStorage._todos.Values.ToList();
        }
    }
}