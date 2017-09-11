namespace _07_Food_Shortage.Models
{
    using Interfaces;

    public class Rebel : IRebel
    {
        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
            this.Food = 0;
        }

        public int Age { get; private set; }

        public int Food { get; private set; }

        public string Group { get; private set; }

        public string Name { get; private set; }

        public int BuyFood()
        {
            this.Food += 5;
            return 5;
        }
    }
}
