namespace _12_Threeuple
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            List<string> nameTokens = firstLine.Take(firstLine.Length - 2).ToList();
            string name = string.Join(" ", nameTokens);
            string address = firstLine[firstLine.Length - 2];
            string town = firstLine.LastOrDefault();
            Threeuple<string, string, string> firstThreeuple = 
                new Threeuple<string, string, string>(name, address, town);
            Console.WriteLine(firstThreeuple);

            string[] secondLine = Console.ReadLine().Split(' ');
            name = secondLine[0];
            int beerAmount = int.Parse(secondLine[1]);
            string isDrunkValue = secondLine[2];
            bool isDrunk = isDrunkValue == "drunk" ? true : false;
            Threeuple<string, int, bool> secondThreeuple = 
                new Threeuple<string, int, bool>(name, beerAmount, isDrunk);
            Console.WriteLine(secondThreeuple);

            string[] thirdLine = Console.ReadLine().Split(' ');
            name = thirdLine[0];
            double accountBalance = double.Parse(thirdLine[1]);
            string bankName = thirdLine[2];
            Threeuple<string, double, string> thirdThreeuple = 
                new Threeuple<string, double, string>(name, accountBalance, bankName);
            Console.WriteLine(thirdThreeuple);
        }
    }
}
