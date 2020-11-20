namespace Framework.Domain
{
    public abstract class EntityBase<TKey>
    {
        public TKey Id { get;protected set; }
        //public string Version { get;protected set; }

        protected EntityBase() { }
        protected EntityBase(TKey id)
        {
            this.Id = id;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != this.GetType()) return false;

            var entity = obj as EntityBase<TKey>;
            return this.Id.Equals(entity.Id);
        }
    }
}
