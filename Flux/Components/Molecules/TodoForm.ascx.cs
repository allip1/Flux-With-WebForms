using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FormsFluxProto.Models;

namespace FormsFluxProto.Flux.Components.Molecules
{
    public partial class TodoForm : System.Web.UI.UserControl
    {
        public event EventHandler Submit_Todo;

        private TodoModel Todo
        {
            get
            {
                return new TodoModel(this.todo_text.Text);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Create_Btn_Clicked(object sender, EventArgs e)
        {
            if(Submit_Todo != null)
            {
                Submit_Todo(this.Todo, e);
            }
        }
    }
}