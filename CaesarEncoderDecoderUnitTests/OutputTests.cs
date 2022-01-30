using CaesarEncoderDecoder.CaesarEncoderDecoderSrc.IO;
using Moq;
using Xunit;

namespace CaesarEncoderDecoderUnitTests
{
    public class OutputTests
    {
        [Fact]
        public void TestGetOutputMessage_SeeMessage()
        {
            var message = "Hello";

            var mockConsoleIO = new Mock<IConsoleIO>();

            var output = new Output(mockConsoleIO.Object);
            //act
            output.GetOutputMessage(message);
            //assert
            mockConsoleIO.Verify(t => t.WriteLine(message), Times.Once());
        }
    }
}
