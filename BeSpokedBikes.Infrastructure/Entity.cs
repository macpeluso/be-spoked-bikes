using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeSpokedBikes.Infrastructure
{
    public interface IEntity
    {

        List<INotification> DomainEvents { get; }
        void ClearDomainEvents();
        void RemoveDomainEvent(INotification eventItem);
        void AddDomainEvent(INotification eventItem);
    }
    public abstract class Entity<T> : IEntity where T : struct
    {
        int? requestedHashCode;
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual T Id { get; protected set; }
        private List<INotification> domainEvents;
        public List<INotification> DomainEvents => this.domainEvents;

        public void AddDomainEvent(INotification eventItem)
        {
            this.domainEvents = this.domainEvents ?? new List<INotification>();
            this.domainEvents.Add(eventItem);
        }

        public void RemoveDomainEvent(INotification eventItem)
        {
            this.domainEvents?.Remove(eventItem);
        }

        public void ClearDomainEvents()
        {
            this.domainEvents?.Clear();
        }

        public bool IsTransient()
        {
            return this.Id.Equals(default(T));
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Entity<T>))
                return false;

            if (Object.ReferenceEquals(this, obj))
                return true;

            if (this.GetType() != obj.GetType())
                return false;

            Entity<T> item = (Entity<T>)obj;

            if (item.IsTransient() || this.IsTransient())
                return false;
            else
                return item.Id.Equals(this.Id);
        }

        public override int GetHashCode()
        {
            if (!IsTransient())
            {
                if (!this.requestedHashCode.HasValue)
                    this.requestedHashCode = this.Id.GetHashCode() ^ 31; // XOR for random distribution (http://blogs.msdn.com/b/ericlippert/archive/2011/02/28/guidelines-and-rules-for-gethashcode.aspx)

                return this.requestedHashCode.Value;
            }
            else
                return base.GetHashCode();

        }
        public static bool operator ==(Entity<T> left, Entity<T> right)
        {
            if (Object.Equals(left, null))
                return (Object.Equals(right, null)) ? true : false;
            else
                return left.Equals(right);
        }

        public static bool operator !=(Entity<T> left, Entity<T> right)
        {
            return !(left == right);
        }
    }
}
