namespace Lesson7_Generic
{
    public class Pair<S, T>
    {
        private S name;
        private T number;

        public Pair(S name, T number)
        {
            this.name = name;
            this.number = number;
        }
        public S Name
        {
            get { return name; }
        }
        public T Number
        {
            get { return number; }
        }
    }
}
