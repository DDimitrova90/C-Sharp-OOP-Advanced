namespace _01_Database
{
    using Contracts;
    using Models;
    using System;

    public class Startup
    {
        public static void Main()
        {
            try
            {
                IDatabase database = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
                Console.WriteLine(string.Join(" ", database.Fetch()));
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
        }
    }
}
