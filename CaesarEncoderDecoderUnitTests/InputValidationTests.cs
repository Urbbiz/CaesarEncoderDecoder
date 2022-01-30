using CaesarEncoderDecoder.CaesarEncoderDecoderSrc.Validations;
using FluentAssertions;
using Xunit;

namespace CaesarEncoderDecoderUnitTests
{
    public class InputValidationTests
    {
        [Theory]
        [InlineData("12")]
        [InlineData("0")]
        [InlineData("25")]
        public void TestIsOnlyNumberRange0To25_IsTrue(string input)
        {
            //Arrange
            var inputValidation = new InputValidation();
            //Act
            var result = inputValidation.IsOnlyNumberRange0To25(input);
            //Assert
            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("Test")]
        [InlineData("26")]
        [InlineData("-1!")]
        public void TestIsOnlyNumberRange0To25_IsFalse(string input)
        {
            //Arrange
            var inputValidation = new InputValidation();
            //Act
            var result = inputValidation.IsOnlyNumberRange0To25(input);
            //Assert
            result.Should().BeFalse();
        }
    }
}
