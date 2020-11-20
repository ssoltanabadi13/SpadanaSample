using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.Events
{
    public class EventAggregator:IEventListener,IEventPublisher
    {
        private List<object> _subscriber=new List<object>();
        public void Publish<T>(T eventToPublish) where T : IEvent
        {
            var handlers = _subscriber.OfType<IEventHandler<T>>().ToList();
            handlers.ForEach(x =>
            {
                x.Handle(eventToPublish);
            });
        }
        public void Subscrib<T>(IEventHandler<T> handler) where T : IEvent
        {
            _subscriber.Add(handler);
        }
        public void UnSubscrib<T>(T eventToPublish) where T : IEvent
        {
            _subscriber.Remove(eventToPublish);
        }


     
    }
}
