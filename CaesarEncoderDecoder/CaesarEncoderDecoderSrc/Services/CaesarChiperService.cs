using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarEncoderDecoder.CaesarEncoderDecoderSrc.Services
{
    public class CaesarChiperService : ICaesarChiperService
    {
        public string GetEncodedString(string input, int key)
        {
            string encodedString = string.Empty;

            foreach (char character in input)

                encodedString += GetEncodedCharacter(character, key);

            return encodedString;
        }

        public string GetDecodedString(string encodedString, int key)
        {
            return GetEncodedString(encodedString, 26 - key);
        }

        private char GetEncodedCharacter(char character, int key)
        {
            if (!char.IsLetter(character))
                return character;

            char offset = char.IsUpper(character) ? 'A' : 'a';
            return (char)((((character + key) - offset) % 26) + offset);
        }
    }
}
