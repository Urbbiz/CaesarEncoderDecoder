using CaesarEncoderDecoder.CaesarEncoderDecoderSrc.Validations;
using FluentAssertions;
using Xunit;

namespace CaesarEncoderDecoderUnitTests
{
    public class InputValidationTests
    {
        [Theory]
        [InlineData("12", true)]
        [InlineData("0", true)]
        [InlineData("26", false)]
        [InlineData("Test", false)]
        public void TestIsOnlyNumberRange0To25_ReturnsExpectedValue(string input, bool resultValue)
        {
            //Arrange
            var inputValidation = new InputValidation();
            //Act
            var result = inputValidation.IsOnlyNumberRange0To25(input);
            //Assert
            result.Should().Be(resultValue);
        }
    }
}
