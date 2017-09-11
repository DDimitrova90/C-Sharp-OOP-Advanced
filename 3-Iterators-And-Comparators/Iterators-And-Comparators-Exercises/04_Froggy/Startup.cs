namespace _04_Froggy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            List<int> stones = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, 
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Lake<int> myLake = new Lake<int>(stones);
            List<int> result = new List<int>();
            foreach (var item in myLake)
            {
                result.Add(item);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
