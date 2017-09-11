namespace NUnit.Tests
{
    using Framework;
    using Skeleton.Interfaces;
    using Skeleton.Models;
    using System;

    [TestFixture]
    public class DummyTests
    {
        private const int DummyHealth = 10;
        private const int DummyExperience = 10;

        private ITarget dummy;

        [SetUp]
        public void TestInIt()
        {
            this.dummy = new Dummy(DummyHealth, DummyExperience);
        }
    
        [Test]
        public void DummyLosesHealthIfAttacked()
        {
            // Arrange

            // Act
            this.dummy.TakeAttack(1);

            // Assert
            Assert.AreEqual(9, this.dummy.Health, "Dummy does not lose health.");
            //Assert.IsTrue(this.dummy.Health == 9);
        }

        [Test]
        public void DeadDummyThrowsExceptionIfAttacked()
        {
            // Arrange
            this.dummy = new Dummy(1, DummyExperience);

            // Act
            this.dummy.TakeAttack(1);

            // Assert
            var exception = Assert.Throws<InvalidOperationException>(() => this.dummy.TakeAttack(1), "Dummy is not dead.");
            Assert.That(exception.Message, Is.EqualTo("Dummy is dead."));
        }

        [Test]
        public void DeadDummyCanGiveXP()
        {
            // Arrange
            this.dummy = new Dummy(0, DummyExperience);

            // Act

            // Assert
            Assert.IsTrue(this.dummy.IsDead(), "Dummy is not dead and can't give XP.");
        }

        [Test]
        public void AliveDummyCantGiveXP()
        {
            // Arrange

            // Act

            // Assert
            var exception = Assert.Throws<InvalidOperationException>(() => this.dummy.GiveExperience(), "Dummy is not alive and can give XP.");
            Assert.That(exception.Message, Is.EqualTo("Target is not dead."));
        }
    }
}
