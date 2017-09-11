namespace _01_Database.Models
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Database : IDatabase
    {
        private const int DefaultCapacity = 16;

        private readonly int[] initialElements;
        private readonly IList<int> data;
        private int currentCapacity;

        public Database(params int[] elements)
        {
            this.initialElements = elements;
            this.data = new List<int>();
            this.currentCapacity = 0;
            this.SetData();
        }

        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }

        public void SetData()
        {
            if (this.initialElements == null)
            {
                throw new ArgumentNullException("Database");
            }

            if (this.initialElements.Length > 16)
            {
                throw new InvalidOperationException("Array capacity must me 16.");
            }

            for (int i = 0; i < this.initialElements.Length; i++)
            {
                this.data.Add(this.initialElements[i]);
            }

            this.currentCapacity = this.data.Count;
        }

        public void Add(int element)
        {
            if (this.currentCapacity >= DefaultCapacity)
            {
                throw new InvalidOperationException("The array is full. You can't add more elements.");
            }

            this.data.Add(element);
            this.currentCapacity++;
        }

        public void Remove()
        {
            if (this.data.Count == 0)
            {
                throw new InvalidOperationException("There are no elements in the array.");
            }

            this.data.RemoveAt(this.data.Count - 1);
            this.currentCapacity--;
        }

        public int[] Fetch()
        {
            int[] temp = new int[this.currentCapacity];
            Array.Copy(this.data.ToArray(), temp, this.currentCapacity);

            return temp;
        }
    }
}
