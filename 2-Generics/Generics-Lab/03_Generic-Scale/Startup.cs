namespace _03_Generic_Scale
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            Scale<int> scale = new Scale<int>(2, 6);

            Console.WriteLine(scale.GetHavier());
        }
    }
}
