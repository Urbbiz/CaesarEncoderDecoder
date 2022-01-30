using CaesarEncoderDecoder.CaesarEncoderDecoderSrc.IO;
using FluentAssertions;
using Moq;
using Xunit;

namespace CaesarEncoderDecoderUnitTests
{
    public class InputTests
    {
        [Fact]
        public void TestGetInputString_OrOutputStringCorrect()
        {
            ///Arrange
            var text = "Test string";

            var mockConsoleIO = new Mock<IConsoleIO>();

            mockConsoleIO.Setup(t => t.ReadLine()).Returns(text);

            var input = new Input(mockConsoleIO.Object);

            //act
            var result = input.GetInputString();

            //assert
            result.Should().Be("Test string");


        }

    }
}
