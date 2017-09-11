namespace _04_Collector
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            Spy spy = new Spy();
            string result = spy.CollectGettersAndSetters("_04_Collector.Hacker");
            Console.WriteLine(result);
        }
    }
}
