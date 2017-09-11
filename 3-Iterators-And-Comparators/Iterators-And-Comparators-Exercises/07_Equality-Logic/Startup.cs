namespace _07_Equality_Logic
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            SortedSet<Person> sortedPeople = new SortedSet<Person>(new PersonComparator());
            HashSet<Person> people = new HashSet<Person>(new PersonComparator());

            int peopleCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < peopleCount; i++)
            {
                string[] personArgs = Console.ReadLine().Split(' ');
                string name = personArgs[0];
                int age = int.Parse(personArgs[1]);

                Person person = new Person(name, age);
                sortedPeople.Add(person);
                people.Add(person);
            }

            Console.WriteLine(sortedPeople.Count);
            Console.WriteLine(people.Count);
        }
    }
}
