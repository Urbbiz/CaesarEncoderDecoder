using System.Text.RegularExpressions;

namespace CaesarEncoderDecoder.CaesarEncoderDecoderSrc.Validations
{
    public class InputValidation : IInputValidation
    {
        public bool IsOnlyNumberRange0To25(string? input)
        {
            return Regex.IsMatch(input ?? "", "^^(2[0-5]|1[0-9]|[0-9])$");
        }
    }
}
