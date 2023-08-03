using System.Reflection;

namespace TrialsSystem.Shared.Domain.AggregatesModel.Base
{
    public abstract class Enumeration : IComparable
    {
        public abstract int Id { get; protected set; }
        public abstract string Name { get; protected set; }

        public Enumeration(int id, string name) => (Id, Name) = (id, name);

        public override string ToString() => Name;

        public static IEnumerable<T> GetAll<T>() where T : Enumeration =>
            typeof(T).GetFields(BindingFlags.Public | 
                                BindingFlags.Static | 
                                BindingFlags.DeclaredOnly)
                     .Select(f => f.GetValue(null))
                     .Cast<T>();

        public override bool Equals(object? obj)
        {
            if(obj is not Enumeration otherValue)
            {
                return false;
            }

            var typeMatches = GetType().Equals(obj.GetType());
            var valueMatches = Id.Equals(otherValue.Id);

            return typeMatches && valueMatches;
        }

        public int CompareTo(object? obj)
        {
            if(obj is not Enumeration otherValue)
            {
                return 1;
            }

            return Id.CompareTo(otherValue.Id);
        }
    }
}
