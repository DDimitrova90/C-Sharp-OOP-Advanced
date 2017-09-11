namespace _02_Extended_Database.Tests
{
    using Contracts;
    using Models;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class PersonTests
    {
        private IPerson person;

        [Test]
        public void CtorShouldAcceptUsernameAndId()
        {
            // Arrange
            this.person = new Person(1, "Pesho");

            // Assert
            Assert.AreEqual(1, this.person.Id, "The id is different.");
            Assert.AreEqual("Pesho", this.person.Username, "The username is different.");
        }

        [Test]
        public void PersonCannotBeCreatedWithNegativeId()
        {
            // Assert
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => new Person(-1, "Pesho"), "Id is not negative.");
            Assert.That(exception.Message, Is.EqualTo("Specified argument was out of the range of valid values.\r\nParameter name: Id must be non negative number."));
        }

        [Test]
        public void PersonCannotBeCreatedWithNullUsername()
        {
            // Assert
            var exception = Assert.Throws<ArgumentNullException>(() => new Person(1, null), "Username is not null.");
            Assert.That(exception.Message, Is.EqualTo("Value cannot be null.\r\nParameter name: Username"));
        }
    }
}
