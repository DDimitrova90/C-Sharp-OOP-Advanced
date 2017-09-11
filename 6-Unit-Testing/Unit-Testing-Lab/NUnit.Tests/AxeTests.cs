namespace NUnit.Tests
{
    using NUnit.Framework;
    using Skeleton.Interfaces;
    using Skeleton.Models;
    using System;

    [TestFixture]
    public class AxeTests
    {
        //  we can use fake weapon and target
        private const int AxeAttack = 10;
        private const int AxeDurability = 10;
        private const int DummyHealth = 10;
        private const int DummyExperience = 10;

        private IWeapon axe;
        private ITarget dummy;

        [SetUp]
        public void TestInIt()
        {
            this.axe = new Axe(AxeAttack, AxeDurability);
            this.dummy = new Dummy(DummyHealth, DummyExperience);
        }

        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            // Arrange

            // Act
            this.axe.Attack(this.dummy);

            // Assert
            Assert.AreEqual(9, this.axe.DurabilityPoints, "Axe does not lose durability.");
        }

        [Test]
        public void BrokenAxeCantAttack()
        {
            // Arrange
            this.axe = new Axe(1, 1);

            // Act
            this.axe.Attack(dummy);

            // Assert
            var exception = Assert.Throws<InvalidOperationException>(() => this.axe.Attack(dummy), "Axe is not broken.");
            Assert.That(exception.Message, Is.EqualTo("Axe is broken."));
        }
    }
}
