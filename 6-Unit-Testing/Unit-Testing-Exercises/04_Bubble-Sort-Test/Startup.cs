namespace _04_Bubble_Sort_Test
{
    using Contracts;
    using Models;
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            IBubble myBubble = new Bubble();

            try
            {
                IList<int> result = myBubble.Sort(new List<int> { 3, 5, 2, 4, 1 });
                Console.WriteLine(string.Join(" ", result));
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
        }
    }
}
