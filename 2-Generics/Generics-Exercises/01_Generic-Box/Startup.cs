namespace _01_Generic_Box
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Box<int> intBox = new Box<int>(number);

            string text = Console.ReadLine();
            Box<string> stringBox = new Box<string>(text);

            Console.WriteLine(intBox.ToString());
            Console.WriteLine(stringBox.ToString());
        }
    }
}
