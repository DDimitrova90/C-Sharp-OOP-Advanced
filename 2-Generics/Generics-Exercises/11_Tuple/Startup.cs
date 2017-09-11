namespace _11_Tuple
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string[] firstLine = Console.ReadLine().Split();
            List<string> nameTokens = firstLine.Take(firstLine.Length - 1).ToList();
            string name = string.Join(" ", nameTokens);
            string adress = firstLine.LastOrDefault();
            Tuple<string, string> firstTuple = new Tuple<string, string>(name, adress);
            Console.WriteLine(firstTuple);

            string[] secondLine = Console.ReadLine().Split();
            name = secondLine[0];
            int amountOfBeer = int.Parse(secondLine[1]);
            Tuple<string, int> secondTuple = new Tuple<string, int>(name, amountOfBeer);
            Console.WriteLine(secondTuple);

            string[] thirdLine = Console.ReadLine().Split();
            int intItem = int.Parse(thirdLine[0]);
            double doubleItem = double.Parse(thirdLine[1]);
            Tuple<int, double> thirdTuple = new Tuple<int, double>(intItem, doubleItem);
            Console.WriteLine(thirdTuple);
        }
    }
}
