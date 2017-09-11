namespace _01_Define_An_Interface_IPerson
{
    public class Citizen : IPerson
    {
        public Citizen(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int Age { get; private set; }

        public string Name { get; private set; }
    }
}
