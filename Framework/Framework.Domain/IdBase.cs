using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Domain
{
    public abstract class IdBase<T> :ValueObjectBase
    {
        public T DbId { get;private set; }
        protected IdBase(){}

        protected IdBase(T dbId)
        {
            DbId = dbId;
        }

        public override int GetHashCode()
        {
            return this.DbId.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (this.GetType() != obj.GetType()) return false;
            var otherId = obj as IdBase<T>;
            return otherId != null && otherId.DbId.Equals(this.DbId);
        }
    }
    
}
