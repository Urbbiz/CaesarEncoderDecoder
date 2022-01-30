using CaesarEncoderDecoder.CaesarEncoderDecoderSrc.Services;
using CaesarEncoderDecoder.CaesarEncoderDecoderSrc.IO;
using CaesarEncoderDecoder.CaesarEncoderDecoderSrc.Validations;
using CaesarEncoderDecoder.CaesarEncoderDecoderSrc.Helpers;

var ConsoleIO = new ConsoleIO();

var Input = new Input(ConsoleIO);

var Output = new Output(ConsoleIO);

var InputValidation = new InputValidation();

var CaesarChiperService = new CaesarChiperService();

string? keyString;

Output.GetOutputMessage(Message.Welcome);

Output.GetOutputMessage(Message.InputString);

string? text = Input.GetInputString();

do
{
    Output.GetOutputMessage(Message.InputKey);

    keyString = Input.GetInputString();

    if (InputValidation.IsOnlyNumberRange0To25(keyString) == false)
    {
        Output.GetOutputMessage(Message.InputKeyValidation);
    }

} while (InputValidation.IsOnlyNumberRange0To25(keyString) == false);

int key = Int32.Parse(keyString);


string encodeString = CaesarChiperService.GetEncodedString(text, key);

string decodeString = CaesarChiperService.GetDecodedString(encodeString, key);

Output.GetOutputMessage(Message.EncodeString + decodeString);

Output.GetOutputMessage(Message.DecodeString + encodeString);