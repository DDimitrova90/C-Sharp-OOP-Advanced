namespace _03_Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class Stack<T> : IEnumerable<T>
    {
        private readonly IList<T> elements;

        public Stack()
        {
            this.elements = new List<T>();
        }

        public void Push(List<T> elementsToPush)
        {
            foreach (var element in elementsToPush)
            {
                this.elements.Add(element);
            }
        }

        public void Pop()
        {
            if (this.elements.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }

            this.elements.RemoveAt(this.elements.Count - 1);
        }

        public string Print()
        {
            StringBuilder sb = new StringBuilder();

            if (this.elements.Count > 0)
            {
                for (int i = this.elements.Count - 1; i >= 0; i--)
                {
                    sb.AppendLine(this.elements[i].ToString());
                }
            }

            return sb.ToString().Trim();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.elements.Count - 1; i >= 0; i--)
            {
                yield return this.elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
