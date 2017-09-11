namespace _03_ListIterator.Tests
{
    using _03_Iterator_Test.Contracts;
    using _03_Iterator_Test.Models;
    using NUnit.Framework;

    [TestFixture]
    public class OutputWriterTests
    {
        private const string ExampleElement = "Example";

        [Test]
        public void WriteLineMethodPrintElement()
        {
            // Arrange
            IOutputWriter outputWriter = new OutputWriter();

            // Act
            outputWriter.WriteLine("Pesho");

            // Assert
            Assert.AreEqual("Pesho\r\n", outputWriter.ToString(), "The element is not printed.");
        }
    }
}
