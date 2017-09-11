namespace NUnit.Tests
{
    using Framework;
    using Moq;
    using Skeleton.Interfaces;
    using Skeleton.Models;
    using Skeleton.Models.TestModels;

    [TestFixture]
    public class HeroTests
    {
        private const string HeroName = "Pesho";

        private Hero sut;  // systemUnderTest = sut
        private ITarget dummy;
        private IWeapon axe;

        [SetUp]
        public void TestInIt()
        {
            this.axe = new FakeWeapon();
            this.sut = new Hero(HeroName, this.axe);
            this.dummy = new FakeTarget();
        }

        [Test]
        public void HeroGainsXpWhenTargetDies()
        {
            // Act
            this.sut.Attack(this.dummy);

            // Assert
            Assert.AreEqual(10, this.sut.Experience, "Hero doesn't get experience.");
        }

        [Test]
        public void HeroGainsXpWhenTargetDiesWithMocking()
        {
            // Arrange
            Mock<ITarget> fakeTarget = new Mock<ITarget>();
            fakeTarget.Setup(t => t.Health).Returns(0);
            fakeTarget.Setup(t => t.GiveExperience()).Returns(20);
            fakeTarget.Setup(t => t.IsDead()).Returns(true);
            Mock<IWeapon> fakeWeapon = new Mock<IWeapon>();
            Hero currHero = new Hero("Pesho", fakeWeapon.Object);

            // Act
            currHero.Attack(fakeTarget.Object);

            // Assert
            Assert.AreEqual(20, currHero.Experience, "Hero doesn't get experience.");
        }
    }
}
