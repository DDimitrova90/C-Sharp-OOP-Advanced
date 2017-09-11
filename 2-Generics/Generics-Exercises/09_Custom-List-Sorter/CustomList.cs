namespace _09_Custom_List_Sorter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CustomList<T>
        where T : IComparable<T>
    {
        private IList<T> items;

        public CustomList()
        {
            this.items = new List<T>();
        }

        public CustomList(IList<T> collection)
        {
            this.items = new List<T>(collection);
        }

        public void Add(T element)
        {
            this.items.Add(element);
        }

        public T Remove(int index)
        {
            T element = this.items[index];
            this.items.RemoveAt(index);
        
            return element;
        }

        public bool Contains(T element)
        {
            return this.items.Contains(element);
        }

        public void Swap(int index1, int index2)
        {
            T firstElement = this.items.ElementAt(index1);
            T secondElement = this.items.ElementAt(index2);

            this.items[index1] = secondElement;
            this.items[index2] = firstElement;
        }

        public int CountGreaterThan(T element)
        {
            int count = 0;

            foreach (var item in this.items)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }

        public T Max()
        {
            return this.items.Max();
        }

        public T Min()
        {
            return this.items.Min();
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, this.items);
        }

        public IList<T> GetList()
        {
            return this.items;
        }
    }
}
