namespace _03_Iterator_Test.Models
{
    using Contracts;
    using System;
    using System.Collections.Generic;

    public class ListIterator : IListIterator
    {
        private readonly IList<string> elements;
        private int currentIndex;
        private IOutputWriter outputWriter;

        public ListIterator(params string[] elements)
        {
            this.outputWriter = new OutputWriter();
            this.currentIndex = 0;
            if (elements == null)
            {
                throw new ArgumentNullException("Collection");
            }

            this.elements = elements;
        }

        public int Count
        {
            get { return this.elements.Count; }
        }

        public bool HasNext()
        {
            if (this.currentIndex < this.Count - 1)
            {
                return true;
            }

            return false;
        }

        public bool Move()
        {
            if (this.currentIndex < this.Count - 1)
            {
                this.currentIndex++;
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation! The collection is empty.");
            }

            string currElement = this.elements[this.currentIndex];
            this.outputWriter.WriteLine(currElement);
        }
    }
}
