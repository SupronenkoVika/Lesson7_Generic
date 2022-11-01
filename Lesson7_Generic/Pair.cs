namespace Lesson7_Generic
{
    internal class Pair<T, S>
    {
        public T ID { get; set; }
        public S Name { get; set; }

        public Pair(T id, S name)
        {
            ID = id;
            Name = name;
        }
    }
}
