using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarEncoderDecoder.CaesarEncoderDecoderSrc.IO
{
    public class ConsoleIO : IConsoleIO
    {

        public void WriteLine(string s)
        {
            Console.WriteLine(s);
        }
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
