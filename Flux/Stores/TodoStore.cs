using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FormsFluxProto.Models;
using FormsFluxProto.Flux.Dispatcher;

namespace FormsFluxProto.Flux.Stores
{
    public class TodoStore
    {
        private List<TodoModel> Todos { get; set; }

        public List<TodoModel> GetAll()
        {
            return this.Todos;
        }

        public void SetAll(List<TodoModel> todos)
        {
            this.Todos = todos;
        }

        public static TodoStore Instance
        {
            get
            {
                if (HttpContext.Current.Items["todostore"] == null)
                    HttpContext.Current.Items.Add("todostore", new TodoStore());

                return HttpContext.Current.Items["todostore"] as TodoStore;
            }
        }
    }


}