namespace _05_Comparing_Objects
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] personArgs = input.Split(' ');
                string name = personArgs[0];
                int age = int.Parse(personArgs[1]);
                string town = personArgs[2];

                Person person = new Person(name, age, town);
                people.Add(person);

                input = Console.ReadLine();
            }
            
            int equalPeople = 0;

            int personIndex = int.Parse(Console.ReadLine()) - 1;

            for (int i = 0; i < people.Count; i++)
            {
                if (i != personIndex)
                {
                    if (people[personIndex].CompareTo(people[i]) == 0)
                    {
                        equalPeople++;
                    }
                }
            }

            int notEqualPeople = people.Count - equalPeople - 1;

            if (equalPeople == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalPeople + 1} {notEqualPeople} {people.Count}");
            }
        }
    }
}
