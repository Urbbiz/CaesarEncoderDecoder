namespace CaesarEncoderDecoder.CaesarEncoderDecoderSrc.IO
{
    public class Output : IOutput
    {
        private readonly IConsoleIO _consoleIO;

        public Output(IConsoleIO consoleIO)
        {
            _consoleIO = consoleIO;
        }
        public void GetOutputMessage(string message)
        {
            _consoleIO.WriteLine(message);

        }
    }
}
