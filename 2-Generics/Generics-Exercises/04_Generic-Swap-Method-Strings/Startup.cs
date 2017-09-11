namespace _04_Generic_Swap_Method_Strings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int boxCount = int.Parse(Console.ReadLine());

            List<string> items = new List<string>();

            for (int i = 0; i < boxCount; i++)
            {
                string currString = Console.ReadLine();
                items.Add(currString);
            }

            int[] swapCommandArgs = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int firstIndex = swapCommandArgs[0];
            int secondIndex = swapCommandArgs[1];

            Swap(items, firstIndex, secondIndex);

            foreach (var item in items)
            {
                Box<string> box = new Box<string>(item);
                Console.WriteLine(box.ToString());
            }
        }

        public static void Swap<T>(List<T> items, int firstIndex, int secondIndex)
        {
            T firstItem = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = firstItem;
        }
    }
}
