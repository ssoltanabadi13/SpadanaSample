using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.Events
{
    public interface IEventListener
    {
        void Subscrib<T>(IEventHandler<T> handler) where T : IEvent;
    }
}
