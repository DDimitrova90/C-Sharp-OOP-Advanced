namespace _06_Birthday_Celebrations
{
    using Interfaces;
    using Models;
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            string command = Console.ReadLine();

            List<IHabitant> habitants = new List<IHabitant>();
            List<IBirthdateable> petsAndCitizens = new List<IBirthdateable>();

            while (command != "End")
            {
                string[] commandArgs = command.Split(' ');
                string inputType = commandArgs[0];

                switch (inputType)
                {
                    case "Citizen":
                        string name = commandArgs[1];
                        int age = int.Parse(commandArgs[2]);
                        string id = commandArgs[3];
                        string birthdate = commandArgs[4];
                        petsAndCitizens.Add(new Citizen(name, age, id, birthdate));
                        break;
                    case "Pet":
                        name = commandArgs[1];
                        birthdate = commandArgs[2];
                        petsAndCitizens.Add(new Pet(name, birthdate));
                        break;
                }

                command = Console.ReadLine();
            }

            string year = Console.ReadLine();

            foreach (var habitant in petsAndCitizens)
            {
                if (habitant.Birthdate.EndsWith(year))
                {
                    Console.WriteLine(habitant.Birthdate);
                }
            }
        }
    }
}
