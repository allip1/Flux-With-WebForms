using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FormsFluxProto.Flux.Constants;

namespace FormsFluxProto.Flux.Dispatcher
{
    public class Dispatcher
    {
        Dictionary<TodoEnums, List<Action<Object>>> _callbacks;

        public Dispatcher()
        {
            _callbacks = new Dictionary<TodoEnums, List<Action<object>>>();
        }
        public static Dispatcher Instance
        {
            get
            {
                if (HttpContext.Current.Items["dispatcher"] == null)
                    HttpContext.Current.Items.Add("dispatcher", new Dispatcher());

                return HttpContext.Current.Items["dispatcher"] as Dispatcher;
            }
        }
        public void Register(TodoEnums actiontype, Action<Object> action)
        {
            if(_callbacks.ContainsKey(actiontype))
            {
                _callbacks[actiontype].Add(action);
            }
            else
            {
                _callbacks.Add(actiontype, new List<Action<object>>() { action });
            }
        }

        public void Dispatch(TodoEnums actionType, object data)
        {
            foreach(var callback in _callbacks[actionType])
            {
                callback(data);
            }
        }
    }
}