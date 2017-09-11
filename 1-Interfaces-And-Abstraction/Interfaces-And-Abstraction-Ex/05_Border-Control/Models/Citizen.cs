namespace _05_Border_Control.Models
{
    using Interfaces;

    public class Citizen : ICitizen
    {
        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

        public int Age { get; private set; }

        public string Id { get; private set; }

        public string Name { get; private set; }
    }
}
