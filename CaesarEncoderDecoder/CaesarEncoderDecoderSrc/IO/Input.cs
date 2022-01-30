namespace CaesarEncoderDecoder.CaesarEncoderDecoderSrc.IO
{
    public class Input : IInput
    {
        private readonly IConsoleIO _consoleIO;

        public Input(IConsoleIO consoleIO)
        {
            _consoleIO = consoleIO;
        }

        public string? GetInputString()
        {
            string? inputString = _consoleIO.ReadLine();

            return inputString;
        }
    }
}
