namespace _04_Coding_Tracker
{
    [SoftUni("Ventsi")]
    public class Startup
    {
        [SoftUni("Gosho")]
        public static void Main()
        {
            Tracker tracker = new Tracker();
            tracker.PrintMethodsByAuthor();
        }
    }
}
