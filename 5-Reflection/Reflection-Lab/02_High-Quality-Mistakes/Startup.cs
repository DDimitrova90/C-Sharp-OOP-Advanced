namespace _02_High_Quality_Mistakes
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            Spy spy = new Spy();
            string result = spy.AnalyzeAcessModifiers("_02_High_Quality_Mistakes.Hacker");
            Console.WriteLine(result);
        }
    }
}
