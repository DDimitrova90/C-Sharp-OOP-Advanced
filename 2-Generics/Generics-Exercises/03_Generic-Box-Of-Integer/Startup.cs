namespace _03_Generic_Box_Of_Integer
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(number);
                Console.WriteLine(box.ToString());
            }
        }
    }
}
