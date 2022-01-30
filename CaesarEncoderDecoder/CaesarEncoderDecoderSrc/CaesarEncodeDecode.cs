using CaesarEncoderDecoder.CaesarEncoderDecoderSrc.Helpers;
using CaesarEncoderDecoder.CaesarEncoderDecoderSrc.IO;
using CaesarEncoderDecoder.CaesarEncoderDecoderSrc.Services;
using CaesarEncoderDecoder.CaesarEncoderDecoderSrc.Validations;

namespace CaesarEncoderDecoder.CaesarEncoderDecoderSrc
{
    public class CaesarEncodeDecode
    {
        private readonly IInput _input;

        private readonly IOutput _output;

        private readonly IInputValidation _inputValidation;

        private readonly ICaesarCipherService _caesarCipherService;

        public CaesarEncodeDecode( IInput input, IOutput output, IInputValidation inputValidation,
        ICaesarCipherService caesarChiperService)
        {
            _input = input;

            _output = output;

            _inputValidation = inputValidation;

            _caesarCipherService = caesarChiperService;
        }

        public void Run()
        {
            string? keyString;

            _output.GetOutputMessage(Message.Welcome);

            _output.GetOutputMessage(Message.InputString);

            string? text = _input.GetInputString();

            do
            {
                _output.GetOutputMessage(Message.InputKey);

                keyString = _input.GetInputString();

                if (_inputValidation.IsOnlyNumberRange0To25(keyString) == false)
                {
                    _output.GetOutputMessage(Message.InputKeyValidation);
                }

            } while (_inputValidation.IsOnlyNumberRange0To25(keyString) == false);

            int key = Int32.Parse(keyString);

            string encodeString = _caesarCipherService.GetEncodedString(text, key);

            string decodeString = _caesarCipherService.GetDecodedString(encodeString, key);

            _output.GetOutputMessage(Message.EncodeString + encodeString);

            _output.GetOutputMessage(Message.DecodeString + decodeString);

        }
    }
}
