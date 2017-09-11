namespace _02_Extended_Database.Models
{
    using Contracts;
    using System;

    public class Person : IPerson
    {
        private long id;
        private string username;

        public Person(long id, string username)
        {
            this.Id = id;
            this.Username = username;
        }

        public long Id
        {
            get { return this.id; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Id must be non negative number.");
                }

                this.id = value;
            }
        }

        public string Username
        {
            get { return this.username; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Username");
                }

                this.username = value;
            }
        }
    }
}
