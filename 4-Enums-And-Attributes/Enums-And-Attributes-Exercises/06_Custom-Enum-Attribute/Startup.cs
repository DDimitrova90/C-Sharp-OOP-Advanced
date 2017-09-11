namespace _06_Custom_Enum_Attribute
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string enumType = Console.ReadLine();

            Type type = null;

            if (enumType == "Rank")
            {
                type = typeof(Rank);
            }
            else if (enumType == "Suit")
            {
                type = typeof(Suit);
            }

            object[] attributes = type.GetCustomAttributes(false);

            foreach (var attribute in attributes)
            {
                Console.WriteLine(attribute);
            }
        }
    }
}
