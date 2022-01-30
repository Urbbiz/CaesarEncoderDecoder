using CaesarEncoderDecoder.CaesarEncoderDecoderSrc.Services;
using FluentAssertions;
using Xunit;

namespace CaesarEncoderDecoderUnitTests
{
    public class CaesarCipherServiceTests
    {

        [Theory]
        [InlineData("Dqgulxv", 3, "Andrius")]
        [InlineData("Gdnazme", 12, "Urbonas")]
        public void TestGetDecodedString_isDecoding(string encodedString, int key, string decodedString)
        {
            //Arrange
            var caesarCipherService = new CaesarCipherService();
            //Act
            var result = caesarCipherService.GetDecodedString(encodedString, key);
            //Assert
            result.Should().Be(decodedString);
        }

        [Theory]
        [InlineData("Andrius", 3, "Dqgulxv")]
        [InlineData("Urbonas", 12, "Gdnazme")]
        public void TestGetEncodedString_isEncoding(string inputString, int key, string encodedString)
        {
            //Arrange
            var caesarChiperService = new CaesarCipherService();
            //Act
            var result = caesarChiperService.GetEncodedString(inputString, key);
            //Assert
            result.Should().Be(encodedString);
        }

    }
}
