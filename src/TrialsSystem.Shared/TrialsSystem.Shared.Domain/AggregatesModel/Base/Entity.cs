namespace TrialsSystem.Shared.Domain.AggregatesModel.Base
{
    public abstract class EntityBase
    {
        public abstract string Id { get; protected set; }
        public abstract bool IsDeleted { get; protected set; }
        public abstract DateTime CreatedDate { get; protected set; }
        public abstract DateTime LastModifiedDate { get; protected set; }
    }
}
