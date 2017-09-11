namespace _04_Bubble_Sort.Tests
{
    using _04_Bubble_Sort_Test.Contracts;
    using _04_Bubble_Sort_Test.Models;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class BubbleTests
    {
        private IBubble myBubble = new Bubble();

        [Test]
        public void SortMethodSortsCollectionWithElements()
        {
            // Act
            IList<int> result = this.myBubble.Sort(new List<int> { 3, 5, 2, 4, 1 });

            // Assert
            CollectionAssert.AreEqual(new List<int> { 1, 2, 3, 4, 5 }, result, "The collection is not sorted.");
        }

        [Test]
        public void SortMethodSortsCollectionWithOneElement()
        {
            // Act
            IList<int> result = this.myBubble.Sort(new List<int> { 3 });

            // Assert
            CollectionAssert.AreEqual(new List<int> { 3 }, result, "The collection is not sorted.");
        }

        [Test]
        public void SortMethodSortsCollectionWithZeroElements()
        {
            // Act
            IList<int> result = this.myBubble.Sort(new List<int> { });

            // Assert
            CollectionAssert.AreEqual(new List<int> { }, result, "The collection is not sorted.");
        }

        [Test]
        public void SortMethodShouldNotSortNullObject()
        {
            // Assert
            var exception = Assert.Throws<ArgumentNullException>(() => this.myBubble.Sort(null), "The collection is not null.");
            Assert.That(exception.Message, Is.EqualTo("Value cannot be null.\r\nParameter name: Collection"));
        }
    }
}
