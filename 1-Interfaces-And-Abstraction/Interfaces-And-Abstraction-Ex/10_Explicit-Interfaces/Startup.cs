namespace _10_Explicit_Interfaces
{
    using Interfaces;
    using Models;
    using System;

    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] citizenArgs = input.Split(' ');
                string name = citizenArgs[0];
                string country = citizenArgs[1];
                int age = int.Parse(citizenArgs[2]);

                Citizen citizen = new Citizen(name, country, age);
                IPerson personCitizen = citizen;
                IResident residentCitizen = citizen;

                Console.WriteLine(personCitizen.GetName());
                Console.WriteLine(residentCitizen.GetName());

                input = Console.ReadLine();
            }
        }
    }
}
