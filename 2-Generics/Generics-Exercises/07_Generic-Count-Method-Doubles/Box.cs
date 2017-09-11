namespace _07_Generic_Count_Method_Doubles
{
    using System;

    public class Box<T>
        where T : IComparable<T>
    {
        private T value;

        public Box(T value)
        {
            this.value = value;
        }

        public bool IsGreater(T item)
        {
            if (this.value.CompareTo(item) > 0)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"{this.value.GetType().FullName}: {this.value}";
        }
    }
}
