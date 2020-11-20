using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.Events
{
    public interface IEventHandler<T> where T:IEvent
    {
        void Handle(T @event);
    }
}
