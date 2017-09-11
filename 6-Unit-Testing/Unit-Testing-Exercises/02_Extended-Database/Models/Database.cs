namespace _02_Extended_Database.Models
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Database : IDatabase
    {
        private readonly IList<IPerson> people;
        private readonly IPerson[] initialData;

        public Database(params IPerson[] people)
        {
            this.people = new List<IPerson>();
            this.initialData = people;
            this.SetData();
        }

        public int Count
        {
            get { return this.people.Count; }
        }

        public void SetData()
        {
            if (this.initialData == null)
            {
                throw new ArgumentNullException("Database");
            }

            for (int i = 0; i < this.initialData.Length; i++)
            {
                this.people.Add(this.initialData[i]);
            }
        }

        public void Add(IPerson person)
        {
            IPerson personById = this.people.FirstOrDefault(p => p.Id == person.Id);
            IPerson personByUsername = this.people.FirstOrDefault(p => p.Username == person.Username);

            if (personById != null)
            {
                throw new InvalidOperationException("Person with this Id is already added.");
            }

            if (personByUsername != null)
            {
                throw new InvalidOperationException("Person with this Username is already added.");
            }

            this.people.Add(person);
        }

        public void Remove()
        {
            if (this.people.Count == 0)
            {
                throw new InvalidOperationException("Database is empty.");
            }

            this.people.RemoveAt(this.people.Count - 1);
        }

        public IPerson FindById(long id)
        {
            IPerson personById = this.people.FirstOrDefault(p => p.Id == id);

            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("Id must be non negative number.");
            }

            if (personById == null)
            {
                throw new InvalidOperationException("There is no person with this Id in the database.");
            }

            return personById;
        }

        public IPerson FindByUsername(string username)
        {
            if (username == null)
            {
                throw new ArgumentNullException("Username");
            }

            IPerson personByUsername = this.people.FirstOrDefault(p => p.Username == username);

            if (personByUsername == null)
            {
                throw new InvalidOperationException("There is no person with this Username in the database.");
            }

            return personByUsername;
        }      
    }
}
