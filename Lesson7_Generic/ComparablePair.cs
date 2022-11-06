namespace Lesson7_Generic
{
    public class ComparablePair<T, U> : Pair<T, U>, IComparable<ComparablePair<T, U>>
        where T : IComparable<T>
        where U : IComparable<U>
    {
        public int CompareTo(ComparablePair<T, U>? other)
        {
            int nameCompare = Name.CompareTo(other.Name);
            if (nameCompare != 0)
            {
                return nameCompare;
            }
            else
                return Number.CompareTo(other.Number);
        }

        public ComparablePair(T name, U number) : base(name, number)
        {

        }
    }
}
