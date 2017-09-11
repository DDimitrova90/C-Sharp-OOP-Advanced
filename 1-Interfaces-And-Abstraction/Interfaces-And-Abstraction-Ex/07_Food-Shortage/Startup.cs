namespace _07_Food_Shortage
{
    using Interfaces;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int peopleCount = int.Parse(Console.ReadLine());

            List<IPerson> people = new List<IPerson>();

            for (int i = 0; i < peopleCount; i++)
            {
                string[] personArgs = Console.ReadLine().Split(' ');
                string name = personArgs[0];
                int age = int.Parse(personArgs[1]);

                if (personArgs.Length == 4)
                {
                    string id = personArgs[2];
                    string birthdate = personArgs[3];

                    people.Add(new Citizen(name, age, id, birthdate));
                }
                else if (personArgs.Length == 3)
                {
                    string group = personArgs[2];

                    people.Add(new Rebel(name, age, group));
                }
            }

            string input = Console.ReadLine();
            int totalFood = 0;

            while (input != "End")
            {
                if (people.FirstOrDefault(p => p.Name == input)  != null)
                {
                    IPerson currPerson = people.FirstOrDefault(p => p.Name == input);
                    totalFood += currPerson.BuyFood();
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(totalFood);
        }
    }
}
