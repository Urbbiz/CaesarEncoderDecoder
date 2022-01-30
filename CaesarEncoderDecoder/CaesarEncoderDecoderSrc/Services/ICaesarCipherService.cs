namespace CaesarEncoderDecoder.CaesarEncoderDecoderSrc.Services
{
    public interface ICaesarCipherService
    {
        string GetDecodedString(string encodedString, int key);
        string GetEncodedString(string input, int key);
    }
}