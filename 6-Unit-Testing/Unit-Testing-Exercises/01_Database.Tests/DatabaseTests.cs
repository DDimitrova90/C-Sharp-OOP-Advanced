namespace _01_Database.Tests
{
    using Contracts;
    using Models;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    [TestFixture]
    public class DatabaseTests
    {
        private IDatabase database;
        private int[] sixteenElements = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        private int[] lessThanSixteenElements = new int[] { 1, 2, 3, 4, 5, 6 };
        private int[] moreThanSixteenElements = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };

        [Test]
        public void CtorShouldWorkWithMoreThanOneAndLessThanSixteenElements()
        {
            // Arrange
            this.database = new Database(this.lessThanSixteenElements);

            // Assert
            Assert.AreEqual(6, this.database.Count, "The number of elements is different.");
        }

        [Test]
        public void CtorShouldWorkWithSixteenElements()
        {
            // Arrange
            this.database = new Database(this.sixteenElements);

            // Assert
            Assert.AreEqual(16, this.database.Count, "The number of elements is less than 16.");
        }

        [Test]
        public void CtorShouldWorkWithOneElement()
        {
            // Arrange
            this.database = new Database(1);

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
            var exception = Assert.Throws<ArgumentNullException>(() => new Database(null), "Database is not null.");
            Assert.That(exception.Message, Is.EqualTo("Value cannot be null.\r\nParameter name: Database"));
        }

        [Test]
        public void CtorShouldNotWorkWithMoreThanSixteenElements()
        {
            // Assert
            var exception = Assert.Throws<InvalidOperationException>(() => new Database(this.moreThanSixteenElements), "The number of elements is equal or less than 16.");
            Assert.That(exception.Message, Is.EqualTo("Array capacity must me 16."));
        }

        [Test]
        public void AddMethodShouldAddElement()
        {
            // Arrange
            this.database = new Database();

            // Act
            this.database.Add(5);

            // Assert
            Assert.AreEqual(1, this.database.Count, "Elements is not added.");
        }

        [Test]
        public void AddMethodCantAddElementWhenCapacityIsFull()
        {
            // Arrange
            this.database = new Database(this.sixteenElements);

            // Assert
            var exception = Assert.Throws<InvalidOperationException>(() => this.database.Add(5), "The capacity of the array is not full.");
            Assert.That(exception.Message, Is.EqualTo("The array is full. You can't add more elements."));
        }

        [Test]
        public void AddMethodShouldAddElementAtTheNextFreeCell()
        {
            // Arrange
            this.database = new Database();

            // Act
            this.database.Add(5);
            this.database.Add(10);

            // Assert
            Assert.AreEqual(1, this.database.Count - 1, "The element is not added at the next free cell.");
        }

        [Test]
        public void RemoveMethodShouldRemoveElement()
        {
            // Arrange
            this.database = new Database(this.sixteenElements);

            // Act
            this.database.Remove();

            // Assert
            Assert.AreEqual(15, this.database.Count, "Element is not removed.");
        }

        [Test]
        public void RemoveMethodShouldRemoveElementAtLastIndex()
        {
            // Arrange
            this.database = new Database(this.lessThanSixteenElements);

            // Act
            int lastIndex = this.database.Count - 1;
            this.database.Remove();

            // Assert
            Assert.AreEqual(--lastIndex, this.database.Count - 1, "The removed element is not from the last index.");
            //CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, this.database.Fetch());
        }

        [Test]
        public void RemoveMethodCantRemoveElementWhenArrayIsEmpty()
        {
            // Arrange
            this.database = new Database();

            // Assert
            var exception = Assert.Throws<InvalidOperationException>(() => this.database.Remove(), "The Array is not empty.");
            Assert.That(exception.Message, Is.EqualTo("There are no elements in the array."));
        }

        [Test]
        public void FetchMethodShouldReturnTheCurrentDatabase()
        {
            // Arrange
            this.database = new Database(this.lessThanSixteenElements);

            // Act
            List<int> elements = this.lessThanSixteenElements.ToList();
            this.database.Remove();
            elements.RemoveAt(this.lessThanSixteenElements.Length - 1);
            this.database.Add(7);
            elements.Add(7);
            this.database.Add(8);
            elements.Add(8);

            // Assert
            CollectionAssert.AreEqual(elements.ToArray(), this.database.Fetch(), "The returned array is not the current.");
        }
    }
}
