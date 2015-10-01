using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FormsFluxProto.Models;
using FormsFluxProto.Flux.Actions;
using FormsFluxProto.Flux.Dispatcher;
using FormsFluxProto.Flux.Stores;
using FormsFluxProto.Flux.Constants;

namespace FormsFluxProto.Flux.Components.Pages
{
    public partial class TodoPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //todo
            if (!Page.IsPostBack)
            {
                var service = new FormsFluxProto.Flux.Services.TodoService();
                FormsFluxProto.Flux.Stores.TodoStore.Instance.SetAll(service.GetAll());
            }


            Dispatcher.Dispatcher.Instance.Register(TodoEnums.ADD_TODO,
                                                    data => TodoStore.Instance.SetAll((List<TodoModel>)data));
        }
        
        protected void RenderRows(object sender, RepeaterItemEventArgs e)
        {
            var TodoModel = (TodoModel)e.Item.DataItem;
            var TodoRow = (FormsFluxProto.Flux.Components.Molecules.TodoRow)e.Item.FindControl("todoRow");

            TodoRow.TodoModel = TodoModel; 
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            this.Row_Repeater.DataSource = FormsFluxProto.Flux.Stores.TodoStore.Instance.GetAll();
            this.Row_Repeater.DataBind();

            this.header.Text = "TODO APP";
        }

        protected void Handle_Todo_Submit(object sender, EventArgs e)
        {
            var todo = (TodoModel)sender;

            TodoActions.Add(todo);
        }
        protected void Handle_Toggle_Click(object sender, EventArgs e)
        {
            var todo = (TodoModel)sender;

            TodoActions.Update(todo);
        }

        protected void Handle_Remove_Click(object sender, EventArgs e)
        {
            var todo = (TodoModel)sender;

            TodoActions.Delete(todo);
        }
    }
}