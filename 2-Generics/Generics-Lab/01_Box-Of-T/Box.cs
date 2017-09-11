namespace _01_Box_Of_T
{
    using System.Collections.Generic;
    using System.Linq;

    public class Box<T>
    {
        private IList<T> items;

        public Box()
        {
            this.items = new List<T>();
        }

        public int Count
        {
            get
            {
                return this.items.Count;
            }
        }

        public void Add(T element)
        {
            this.items.Add(element);
        }

        public T Remove()
        {
            T item = this.items.LastOrDefault();
            this.items.RemoveAt(this.items.Count - 1);
            return item;
        }
    }
}