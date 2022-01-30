using CaesarEncoderDecoder.CaesarEncoderDecoderSrc.Services;
using CaesarEncoderDecoder.CaesarEncoderDecoderSrc.IO;
using CaesarEncoderDecoder.CaesarEncoderDecoderSrc.Validations;
using CaesarEncoderDecoder.CaesarEncoderDecoderSrc;

var ConsoleIO = new ConsoleIO();

var Input = new Input(ConsoleIO);

var Output = new Output(ConsoleIO);

var InputValidation = new InputValidation();

var CaesarChiperService = new CaesarChiperService();

var CaesarEncodeDecode = new CaesarEncodeDecode(Input, Output, InputValidation, CaesarChiperService);

//Console.WriteLine (CaesarEncodeDecode.Run());
CaesarEncodeDecode.Run()