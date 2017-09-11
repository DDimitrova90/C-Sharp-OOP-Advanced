namespace _06_Birthday_Celebrations.Models
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
        }

        public int Age { get; private set; }

        public string Birthdate { get; private set; }

        public string Id { get; private set; }

        public string Name { get; private set; }
    }
}
