using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FormsFluxProto.Models;
using FormsFluxProto.Flux.Dispatcher;
using FormsFluxProto.Flux.Constants;

namespace FormsFluxProto.Flux.Actions
{
    public static class TodoActions
    {
        private static void dispatchAllTodos()
        {
           var service = new FormsFluxProto.Flux.Services.TodoService();
           
           Dispatcher.Dispatcher.Instance.Dispatch(Constants.TodoEnums.ADD_TODO, service.GetAll());
        }

        public static  void Add(TodoModel todo)
        {
            
            var service = new FormsFluxProto.Flux.Services.TodoService();
            service.AddTodo(todo);

            dispatchAllTodos();
        }
        public static void Update(TodoModel todo)
        {
            var service = new FormsFluxProto.Flux.Services.TodoService();
            service.UpdateTodo(todo);

            dispatchAllTodos();
        }

        public  static void Delete(TodoModel todo)
        {
            var service = new FormsFluxProto.Flux.Services.TodoService();
            service.DeleteTodo(todo);

            dispatchAllTodos();
        }
    }
}