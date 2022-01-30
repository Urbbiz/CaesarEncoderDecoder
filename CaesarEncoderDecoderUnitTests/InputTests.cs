using CaesarEncoderDecoder.CaesarEncoderDecoderSrc.IO;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            input.GetInputString();

            //assert
            input.GetInputString().Should().Be("Test string");


        }

    }
}
