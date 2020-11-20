using System;
using System.Collections.Generic;
using Framework.Core.Events;

namespace Framework.Domain
{
    public class AggregateRootBase<TKey> :EntityBase<TKey>,IAggregateRoot
    {
        private IEventPublisher _publisher;
        private List<DomainEvent> _publishedEvents = new List<DomainEvent>();
        public DateTime LastModified { get;private set; }
        public DateTime CreateOn { get;private set; }
        protected AggregateRootBase(){}

        protected AggregateRootBase(TKey id, IEventPublisher publisher) : base(id)
        {
            this._publisher = publisher;
            LastModified = DateTime.Now;
            CreateOn = DateTime.Now;
        }
        protected AggregateRootBase(IEventPublisher publisher)
        {
            this._publisher = publisher;
            LastModified = DateTime.Now;
        }

        public void SetPublisher(IEventPublisher publisher)
        {
            this._publisher = publisher;
        }
        
        public void SetId(TKey id)
        {
            this.Id = id;
        }
        public void Publish<TEvent>(TEvent @event) where TEvent : DomainEvent
        {
            this._publishedEvents.Add(@event);
            _publisher.Publish(@event);
            LastModified = DateTime.Now;
        }
        public List<DomainEvent> GetPublishedEvents()
        {
            return this._publishedEvents;
        }
        public void ClearEvents()
        {
            this._publishedEvents.Clear();
        }
    }
}
