namespace _07_Food_Shortage.Models
{
    using Interfaces;

    public class Citizen : ICitizen
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
            this.Food = 0;
        }

        public int Age { get; private set; }

        public string Birthdate { get; private set; }

        public int Food { get; private set; }

        public string Id { get; private set; }

        public string Name { get; private set; }

        public int BuyFood()
        {
            this.Food += 10;
            return 10;
        }
    }
}
