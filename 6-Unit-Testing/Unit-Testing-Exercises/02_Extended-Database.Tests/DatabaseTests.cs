namespace _02_Extended_Database.Tests
{
    using Contracts;
    using Models;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DatabaseTests
    {
        private IDatabase database;
        private IPerson firstPerson = new Person(1, "Pesho");
        private IPerson secondPerson = new Person(2, "Gosho");

        [Test]
        public void CtorShouldWorkWithMoreThanOnePerson()
        {
            // Arrange
            this.database = new Database(this.firstPerson, this.secondPerson);

            // Assert
            Assert.AreEqual(2, this.database.Count, "The number of elements is different.");
        }

        [Test]
        public void CtorShouldWorkWithOnePerson()
        {
            // Arrange
            this.database = new Database(this.firstPerson);

            // Assert
            Assert.AreEqual(1, this.database.Count, "The number of elements is not one.");
        }

        [Test]
        public void CtorShouldWorkWithZeroElements()
        {
            // Arrange
            this.database = new Database();

            // Assert
            Assert.AreEqual(0, this.database.Count, "The number of elements is not zero.");
        }

        [Test]
        public void CtorShouldNotWorkWithNullObject()
        {
            // Assert
            var exception = Assert.Throws<ArgumentNullException>(() => new Database(null), "The element in constructor is not null.");
            Assert.That(exception.Message, Is.EqualTo("Value cannot be null.\r\nParameter name: Database"));
        }

        [Test]
        public void AddMethodAddPersonToTheDatabase()
        {
            //Arrange
            this.database = new Database(this.firstPerson);

            // Act
            this.database.Add(this.secondPerson);

            // Assert
            Assert.AreEqual(2, this.database.Count, "The person is not added.");
        }

        [Test]
        public void AddMethodCannotAddPersonWithTheSameId()
        {
            // Arrange
            this.database = new Database(this.firstPerson, this.secondPerson);

            // Assert
            var exception = Assert.Throws<InvalidOperationException>(() => this.database.Add(this.secondPerson), "There is no person with this id in the database.");
            Assert.That(exception.Message, Is.EqualTo("Person with this Id is already added."));
        }

        [Test]
        public void AddMethodCannotAddPersonWithTheSameUsername()
        {
            // Arrange
            this.database = new Database(this.firstPerson);

            // Assert
            var exception = Assert.Throws<InvalidOperationException>(() => this.database.Add(new Person(2, this.firstPerson.Username)), "There is no person with this username in the database.");
            Assert.That(exception.Message, Is.EqualTo("Person with this Username is already added."));
        }

        [Test]
        public void RemoveMethodShouldRemovePerson()
        {
            // Arrange
            this.database = new Database(this.firstPerson);

            // Act
            this.database.Remove();

            // Assert
            Assert.AreEqual(0, this.database.Count, "Person is not removed from database.");
        }

        [Test]
        public void RemoveMethodCannotRemovePersonFromEmptyDatabase()
        {
            // Arrange
            this.database = new Database();

            // Assert
            var exception = Assert.Throws<InvalidOperationException>(() => this.database.Remove(), "The database is not empty.");
            Assert.That(exception.Message, Is.EqualTo("Database is empty."));
        }

        [Test]
        public void FindByIdMethodFindsPersonFromDatabase()
        {
            // Arrange
            this.database = new Database(this.firstPerson);

            // Act
            IPerson findedPerson = this.database.FindById(1);

            // Assert
            Assert.AreEqual(this.firstPerson, findedPerson, "There is not such person in the database.");
        }

        [Test]
        public void FindByIdMethodCannotFindThePersonInTheDatabase()
        {
            // Arrange
            this.database = new Database(this.firstPerson);

            // Assert
            var exception = Assert.Throws<InvalidOperationException>(() => this.database.FindById(2), "The searched person is in the database.");
            Assert.That(exception.Message, Is.EqualTo("There is no person with this Id in the database."));
        }

        [Test]
        public void FindByIdMethodCannotFindPersonByNegativeId()
        {
            // Arrange
            this.database = new Database(this.firstPerson);

            // Assert
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => this.database.FindById(-1), "The id is not negative.");
            Assert.That(exception.Message, Is.EqualTo("Specified argument was out of the range of valid values.\r\nParameter name: Id must be non negative number."));
        }

        [Test]
        public void FindByUsernameFindsPersonByUsernameFromTheDatabase()
        {
            // Arrange
            this.database = new Database(this.firstPerson);

            // Act
            IPerson personByUsername = this.database.FindByUsername("Pesho");

            // Assert
            Assert.AreEqual(personByUsername, this.firstPerson, "The searched person is not in the database.");
        }

        [Test]
        public void FindByUsernameCannotFindPersonByNullUsernameFromTheDatabase()
        {
            // Arrange
            this.database = new Database(this.firstPerson);

            // Assert
            var exception = Assert.Throws<ArgumentNullException>(() => this.database.FindByUsername(null), "The username is not null.");
            Assert.That(exception.Message, Is.EqualTo("Value cannot be null.\r\nParameter name: Username"));
        }

        [Test]
        public void FindByUsernameCannotFindThePersonInTheDatabase()
        {
            // Arrange
            this.database = new Database(this.firstPerson);

            // Assert
            var exception = Assert.Throws<InvalidOperationException>(() => this.database.FindByUsername("Gosho"), "There is no such person in the database.");
            Assert.That(exception.Message, Is.EqualTo("There is no person with this Username in the database."));
        }
    }
}
