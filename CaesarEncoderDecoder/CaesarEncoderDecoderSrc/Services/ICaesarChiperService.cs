namespace CaesarEncoderDecoder.CaesarEncoderDecoderSrc.Services
{
    public interface ICaesarChiperService
    {
        string GetDecodedString(string encodedString, int key);
        string GetEncodedString(string input, int key);
    }
}