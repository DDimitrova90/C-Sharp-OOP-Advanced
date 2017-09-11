namespace _03_ListIterator.Tests
{
    using _03_Iterator_Test.Contracts;
    using _03_Iterator_Test.Models;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ListIteratorTests
    {
        private const string FirstString = "first";
        private const string SecondString = "second";

        private IListIterator myList;
        private IOutputWriter outputWriter = new OutputWriter();

        [Test]
        public void CtorShouldWorkWithManyElements()
        {
            // Arrange
            this.myList = new ListIterator(FirstString, SecondString);

            // Assert
            Assert.AreEqual(2, this.myList.Count, "The number of element is not as expected.");
        }

        [Test]
        public void CtorShouldWorkWithOneElement()
        {
            // Arrange
            this.myList = new ListIterator(FirstString);

            // Assert
            Assert.AreEqual(1, this.myList.Count, "The number of element is not one.");
        }

        [Test]
        public void CtorShouldWorkWithZeroElements()
        {
            // Arrange
            this.myList = new ListIterator();

            // Assert
            Assert.AreEqual(0, this.myList.Count, "The number of element is not zero.");
        }

        [Test]
        public void CtorShouldNotWorkWithNullObject()
        {
            // Assert
            var exception = Assert.Throws<ArgumentNullException>(() => new ListIterator(null), "The object, sent to constructor, is not null.");
            Assert.That(exception.Message, Is.EqualTo("Value cannot be null.\r\nParameter name: Collection"));
        }
        
        [Test]
        public void HasNextMethodReturnsTrueIfThereIsNextIndex()
        {
            // Arrange
            this.myList = new ListIterator(FirstString, SecondString);
            int startIndex = 0;

            // Assert
            Assert.IsTrue(startIndex < this.myList.Count - 1, "There is no next index.");
        }

        [Test]
        public void HasNextMethodReturnsFalseIfThereIsNotNextIndex()
        {
            // Arrange
            this.myList = new ListIterator(FirstString, SecondString);
            int startIndex = 1;

            // Assert
            Assert.IsTrue(startIndex >= this.myList.Count - 1, "There is next index.");
        }

        [Test]
        public void MoveMethodReturnsTrueIfCanChangeTheCurrentIndex()
        {
            // Arrange
            this.myList = new ListIterator(FirstString, SecondString);

            // Assert
            Assert.AreEqual(true, this.myList.Move(), "The current index can't be moved.");
        }

        [Test]
        public void MoveMethodReturnsFalseIfCannotChangeTheCurrentIndex()
        {
            // Arrange
            this.myList = new ListIterator(FirstString, SecondString);

            // Act
            this.myList.Move();

            // Assert
            Assert.AreEqual(false, this.myList.Move(), "The current index can be moved.");
        }

        [Test]
        public void PrintMethodPrintsCurrentElement()
        {
            // Arrange
            this.myList = new ListIterator(FirstString, SecondString);

            // Act
            this.outputWriter.WriteLine(FirstString);

            // Assert
            Assert.AreEqual(FirstString + "\r\n", this.outputWriter.ToString(), "The printed element is not the current one.");
        }

        [Test]
        public void PrintMethodShouldNotWorkWhenCollectionIsEmpty()
        {
            // Arrange
            this.myList = new ListIterator();

            // Assert
            var exception = Assert.Throws<InvalidOperationException>(() => this.myList.Print(), "The collection is not empty.");
            Assert.That(exception.Message, Is.EqualTo("Invalid Operation! The collection is empty."));
        }
    }
}
