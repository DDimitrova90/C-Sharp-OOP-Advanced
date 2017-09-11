namespace _03_Iterator_Test.Models
{
    using Contracts;
    using System;

    public class OutputWriter : IOutputWriter
    {
        private string element;

        public void WriteLine(string element)
        {
            this.element = element;
            Console.WriteLine(element);
        }

        public override string ToString()
        {
            return this.element + "\r\n";
        }
    }
}
