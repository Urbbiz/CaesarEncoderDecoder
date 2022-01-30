using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
