namespace _07_Equality_Logic
{
    using System.Collections.Generic;

    public class PersonComparator : IComparer<Person>, IEqualityComparer<Person>
    {
        public int Compare(Person firstPerson, Person secondPerson)
        {
            int result = firstPerson.Name.CompareTo(secondPerson.Name);

            if (result == 0)
            {
                result = firstPerson.Age.CompareTo(secondPerson.Age);

                if (result == 0)
                {
                    return 0;
                }
            }

            return result;
        }

        public bool Equals(Person firstPerson, Person secondPerson)
        {
            int nameResult = firstPerson.Name.CompareTo(secondPerson.Name);
            int ageResult = firstPerson.Age.CompareTo(secondPerson.Age);

            return nameResult == 0 && ageResult == 0;
        }

        public int GetHashCode(Person person)
        {
            return person.Name.GetHashCode();
        }
    }
}
