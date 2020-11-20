using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.Events
{
    public class ActionEventHandler<T>:IEventHandler<T> where T:IEvent
    {
        private readonly Action<T> _action;

        public ActionEventHandler(Action<T> action)
        {
            _action = action;
        }
        public void Handle(T @event)
        {
            _action(@event);
        }
    }
}
