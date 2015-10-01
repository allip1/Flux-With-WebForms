using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FormsFluxProto.Models;

namespace FormsFluxProto.Flux.Components.Molecules
{
    public partial class TodoRow : System.Web.UI.UserControl
    {
        private TodoModel _todoModel = null;
        public TodoModel TodoModel
        {
            get
            {
                if (_todoModel == null)
                    _todoModel = ParseModel();

                return _todoModel;
            }
            set
            {
                _todoModel = value;

                this.ID.Value = _todoModel.Id.ToString();
                this.todo_text.Text = _todoModel.Text;
                this.checked_cb.Checked = _todoModel.IsDone;
            }
        }

        private TodoModel ParseModel()
        {
            var id = Guid.Parse(this.ID.Value);
            var text = this.todo_text.Text;
            var isDone = this.checked_cb.Checked;

            return new TodoModel(id, text, isDone);
        }

        public event EventHandler Remove_Clicked_Handler;

        public event EventHandler IsDone_Toggle_Handler;
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Checkbox_IsDone_Clicked(object sender, EventArgs e)
        {
            if(this.IsDone_Toggle_Handler != null)
            {
                this.IsDone_Toggle_Handler(this.TodoModel, e);
            }
        }
        protected void Btn_Remove_Clicked(object sender, EventArgs e)
        {
            if(this.Remove_Clicked_Handler != null)
            {
                this.Remove_Clicked_Handler(this.TodoModel, e);
            }
        }
    }
}