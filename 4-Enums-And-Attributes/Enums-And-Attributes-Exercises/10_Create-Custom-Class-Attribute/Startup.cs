namespace _10_Create_Custom_Class_Attribute
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string command = Console.ReadLine();

            CustomAttribute attribute = (CustomAttribute)typeof(Weapon)
                .GetCustomAttributes(typeof(CustomAttribute), true)
                .FirstOrDefault();

            while (command != "END")
            {
                switch (command)
                {
                    case "Author":
                        Console.WriteLine($"Author: {attribute.Author}");
                        break;
                    case "Revision":
                        Console.WriteLine($"Revision: {attribute.Revision}");
                        break;
                    case "Description":
                        Console.WriteLine($"Class description: {attribute.Description}");
                        break;
                    case "Reviewers":
                        Console.WriteLine($"Reviewers: {string.Join(", ", attribute.Reviewers)}");
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
