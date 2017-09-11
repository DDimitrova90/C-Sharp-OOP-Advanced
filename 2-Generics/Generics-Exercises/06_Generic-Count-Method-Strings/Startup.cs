namespace _06_Generic_Count_Method_Strings
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            int elementsCount = int.Parse(Console.ReadLine());

            List<string> items = new List<string>();

            for (int i = 0; i < elementsCount; i++)
            {
                string element = Console.ReadLine();
                items.Add(element);
            }

            string elementToCompare = Console.ReadLine();

            int result = GetGreaterItemsCount(items, elementToCompare);
            Console.WriteLine(result);
        }

        public static int GetGreaterItemsCount<T>(List<T> items, T element)
        {
            int count = 0;

            foreach (var item in items)
            {
                Box<string> box = new Box<string>(item.ToString());
                
                if (box.IsGreater(element.ToString()))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
