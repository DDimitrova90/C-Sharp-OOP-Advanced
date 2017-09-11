namespace _03_Mission_Private_Impossible
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            Spy spy = new Spy();
            string result = spy.RevealPrivateMethods("_03_Mission_Private_Impossible.Hacker");
            Console.WriteLine(result);
        }
    }
}
