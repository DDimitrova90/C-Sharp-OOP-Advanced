namespace _07_Generic_Count_Method_Doubles
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            int elementsCount = int.Parse(Console.ReadLine());

            List<double> items = new List<double>();

            for (int i = 0; i < elementsCount; i++)
            {
                double element = double.Parse(Console.ReadLine());
                items.Add(element);
            }

            double elementToCompare = double.Parse(Console.ReadLine());

            int result = GetGreaterItemsCount(items, elementToCompare);
            Console.WriteLine(result);
        }

        public static int GetGreaterItemsCount<T>(List<T> items, T element)
        {
            int count = 0;

            foreach (var item in items)
            {
                Box<double> box = new Box<double>(double.Parse(item.ToString()));

                if (box.IsGreater(double.Parse(element.ToString())))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
