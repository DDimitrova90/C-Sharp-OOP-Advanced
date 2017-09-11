namespace _01_Stealer
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            Spy spy = new Spy();
            string result = spy.StealFieldInfo("_01_Stealer.Hacker", "username", "password");

            Console.WriteLine(result);
        }
    }
}
