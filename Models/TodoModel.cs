using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormsFluxProto.Models
{
    public class TodoModel
    {
        public Guid Id { get; private set; }

        public String Text { get; private set; }

        public Boolean IsDone { get; private set; }

        public TodoModel(string text)
        {
            this.Text = text;
            this.IsDone = false;
            this.Id = Guid.NewGuid();
        }
        
        public TodoModel(Guid id, string text, bool isDone)
        {
            this.Text = text;
            this.Id = id;
            this.IsDone = IsDone;
        }

        public void Toggle()
        {
            this.IsDone = !this.IsDone;
        }
    }
}