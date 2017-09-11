namespace _06_Birthday_Celebrations.Models
{
    using Interfaces;

    public class Pet : IPet
    {
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        public string Birthdate { get; private set; }

        public string Name { get; private set; }
    }
}
