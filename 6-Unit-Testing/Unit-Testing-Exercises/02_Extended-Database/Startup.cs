namespace _02_Extended_Database
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
                IPerson firstPerson = new Person(1, "Pesho");
                IPerson secondPerson = new Person(2, "Gosho");
                IPerson thirdPerson = new Person(3, "Pesho");
                //IPerson personWithNegativeId = new Person(-1, "Pesho");
                //IPerson personWithNullUsername = new Person(1, null);
                IDatabase database = new Database(firstPerson);
                database.FindByUsername("Gosho");
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
            catch (ArgumentOutOfRangeException aore)
            {
                Console.WriteLine(aore.Message);
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
        }
    }
}
