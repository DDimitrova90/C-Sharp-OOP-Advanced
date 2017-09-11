namespace BashSoftTesting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using NUnit.Framework;
    using BashSoft.Contracts;
    using BashSoft.DataStructures;

    [TestFixture]
    public class OrderedDataStructureTester
    {
        [SetUp]
        public void TestInIt()
        {
            this.names = new SimpleSortedList<string>();
        }

        private ISimpleOrderedBag<string> names;

        [Test]
        public void TestEmptyCtor()
        {
            // Arrange
            this.names = new SimpleSortedList<string>();

            // Assert
            Assert.AreEqual(16, this.names.Capacity);
            Assert.AreEqual(0, this.names.Size);
        }

        [Test]
        public void TestCtorWithInitialCapacity()
        {
            // Arrange
            this.names = new SimpleSortedList<string>(20);

            // Assert
            Assert.AreEqual(20, this.names.Capacity);
            Assert.AreEqual(0, this.names.Size);
        }

        [Test]
        public void TestCtorWithAllParams()
        {
            // Arrange
            this.names = new SimpleSortedList<string>(StringComparer.OrdinalIgnoreCase, 30);

            // Assert
            Assert.AreEqual(30, this.names.Capacity);
            Assert.AreEqual(0, this.names.Size);
        }

        [Test]
        public void TestCtorWithInitialComparer()
        {
            // Arrange
            this.names = new SimpleSortedList<string>(StringComparer.OrdinalIgnoreCase);

            // Assert
            Assert.AreEqual(16, this.names.Capacity);
            Assert.AreEqual(0, this.names.Size);
        }

        [Test]
        public void TestAddIncreasesSize()
        {
            // Act
            this.names.Add("Nasko");

            // Assert
            Assert.AreEqual(1, this.names.Size);
        }

        [Test]
        public void TestAddNullThrowsException()
        {
            // Assert
            var exception = Assert.Throws<ArgumentNullException>(() => this.names.Add(null));
            Assert.That(exception.Message, Is.EqualTo("Value cannot be null."));
        }

        [Test]
        public void TestAddUnsortedDataIsHeldSorted()
        {
            // Act
            this.names.Add("Rosen");
            this.names.Add("Balkan");
            this.names.Add("Georgi");

            // Assert
            Assert.AreEqual("Balkan", this.names.ToList()[0]);
            Assert.AreEqual("Georgi", this.names.ToList()[1]);
            Assert.AreEqual("Rosen", this.names.ToList()[2]);
        }

        [Test]
        public void TestAddingMoreThanInitialCapacity()
        {
            // Act
            this.names.Add("one");
            this.names.Add("two");
            this.names.Add("three");
            this.names.Add("four");
            this.names.Add("five");
            this.names.Add("six");
            this.names.Add("seven");
            this.names.Add("eight");
            this.names.Add("nine");
            this.names.Add("ten");
            this.names.Add("eleven");
            this.names.Add("twelve");
            this.names.Add("thirdteen");
            this.names.Add("fourteen");
            this.names.Add("fiveteen");
            this.names.Add("sixteen");
            this.names.Add("seventeen");

            // Assert
            Assert.AreEqual(17, this.names.Size);
            Assert.AreNotEqual(16, this.names.Capacity);
        }

        [Test]
        public void TestAddingAllFromCollectionIncreasesSize()
        {
            // Arrange
            List<string> collection = new List<string>() { "Gosho", "Pesho" };

            // Act
            this.names.AddAll(collection);

            // Assert
            Assert.AreEqual(2, this.names.Size);
        }

        [Test]
        public void TestAddingAllFromNullThrowsException()
        {
            // Assert
            var exception = Assert.Throws<ArgumentNullException>(() => this.names.AddAll(null));
            Assert.That(exception.Message, Is.EqualTo("Value cannot be null."));
        }

        [Test]
        public void TestAddAllKeepsSorted()
        {
            // Arrange
            List<string> temp = new List<string>() { "Pesho", "Gosho" };

            // Act
            this.names.AddAll(temp);

            // Assert
            Assert.AreEqual("Gosho", this.names.ToList()[0]);
            Assert.AreEqual("Pesho", this.names.ToList()[1]);
        }

        [Test]
        public void TestRemoveValidElementDecreasesSize()
        {
            // Act
            this.names.Add("Gosho");
            this.names.Remove("Gosho");

            // Assert
            Assert.Greater(1, this.names.Size);
        }

        [Test]
        public void TestRemoveValidElementRemovesSelectedOne()
        {
            // Act
            this.names.Add("ivan");
            this.names.Add("nasko");
            this.names.Remove("ivan");

            // Assert
            Assert.False(this.names.Contains("ivan"));
        }

        [Test]
        public void TestRemovingNullThrowsException()
        {
            // Act
            this.names.Add("gosho");

            // Assert
            var exception = Assert.Throws<InvalidOperationException>(() => this.names.Remove(null));
            Assert.That(exception.Message, Is.EqualTo("Invalid operation!"));
        }

        [Test]
        public void TestJoinWithNull()
        {
            // Act
            this.names.Add("Gosho");
            this.names.Add("Pesho");

            // Assert
            var exception = Assert.Throws<InvalidOperationException>(() => this.names.JoinWith(null));
            Assert.That(exception.Message, Is.EqualTo("Invalid operation!"));
        }

        [Test]
        public void TestJoinWorksFine()
        {
            // Act
            this.names.Add("Gosho");
            this.names.Add("Pesho");
            string result = this.names.JoinWith(", ");

            // Assert
            Assert.AreEqual("Gosho, Pesho", result);
        }
    }
}
