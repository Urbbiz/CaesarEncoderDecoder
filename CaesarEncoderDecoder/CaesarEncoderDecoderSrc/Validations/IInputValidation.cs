namespace CaesarEncoderDecoder.CaesarEncoderDecoderSrc.Validations
{
    public interface IInputValidation
    {
        bool IsOnlyNumberRange0To25(string? input);
    }
}