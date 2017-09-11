namespace _02_Generic_Box_Of_String
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int stringsNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < stringsNumber; i++)
            {
                string currString = Console.ReadLine();
                Box<string> box = new Box<string>(currString);
                Console.WriteLine(box.ToString());
            }
        }
    }
}
