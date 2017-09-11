namespace _05_Border_Control
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

            while (command != "End")
            {
                string[] commandArgs = command.Split(' ');

                if (commandArgs.Length == 3)
                {
                    string name = commandArgs[0];
                    int age = int.Parse(commandArgs[1]);
                    string id = commandArgs[2];

                    habitants.Add(new Citizen(name, age, id));
                }
                else if (commandArgs.Length == 2)
                {
                    string model = commandArgs[0];
                    string id = commandArgs[1];

                    habitants.Add(new Robot(model, id));
                }

                command = Console.ReadLine();
            }

            string idsEnd = Console.ReadLine();

            foreach (var habitant in habitants)
            {
                if (habitant.Id.EndsWith(idsEnd))
                {
                    Console.WriteLine(habitant.Id);
                }
            }
        }
    }
}
