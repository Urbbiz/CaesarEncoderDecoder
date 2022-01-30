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

        private readonly ICaesarChiperService _caesarChiperService;

        public CaesarEncodeDecode( IInput input, IOutput output, IInputValidation inputValidation,
        ICaesarChiperService caesarChiperService)
        {
            _input = input;

            _output = output;

            _inputValidation = inputValidation;

            _caesarChiperService = caesarChiperService;
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

            string encodeString = _caesarChiperService.GetEncodedString(text, key);

            string decodeString = _caesarChiperService.GetDecodedString(encodeString, key);

            _output.GetOutputMessage(Message.DecodeString + encodeString);

            _output.GetOutputMessage(Message.EncodeString + decodeString);
        }
    }
}
