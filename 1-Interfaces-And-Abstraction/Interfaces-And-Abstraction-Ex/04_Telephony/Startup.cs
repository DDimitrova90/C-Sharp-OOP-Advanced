namespace _04_Telephony
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');
            string[] sites = Console.ReadLine().Split(' ');

            Smartphone smarthPhone = new Smartphone();

            foreach (var number in numbers)
            {
                Console.WriteLine(smarthPhone.Call(number));
            }

            foreach (var site in sites)
            {
                Console.WriteLine(smarthPhone.BrowseWeb(site));
            }
        }
    }
}
